using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using WordAnalyser.Model;

namespace BookReader
{
    /// <summary>
    /// - 仅从目前有的字库中进行统计.
    /// - 使用Top1020 作为图书ID，同时保存前5行单词作为书籍简介，这样可以留待进一步人工
    /// 完善书籍基础信息、勘误。
    /// </summary>
    class Parser
    {
        private double TotalTime = 0;
        private int TotalBook = 0;
        private Int64 TotalWords = 0;
        public void ReadTxtFile(string filePathName, Language language, BookCategory category, BookContext context)
        {
            var sw = new Stopwatch();

            var fi = new FileInfo(filePathName);
            if (fi.Extension != ".txt")
                return;

            sw.Start();
            var lines = File.ReadLines(filePathName);
            var cntdict = new Dictionary<char, int>();
            int wc = 0;
            int tc = 0;
            int linenum = 0;
            foreach (var line in lines)
            {
                ++linenum;
                if (linenum < 3) // todo: this is temp for downloaded book
                    continue;
                var cline = GetLetters(line, language);
                foreach (var letter in cline)
                {
                    if (cntdict.ContainsKey(letter))
                    {
                        cntdict[letter] += 1;
                    }
                    else
                    {
                        cntdict[letter] = 1;
                        ++wc;
                    }
                    ++tc;
                }
            }

            if (wc < 50)
            {
                Console.WriteLine(
                    $"{TotalBook}: Parse total words: {tc}, different words: {wc}, less than 50!!!!! {fi.Name.Replace(".txt", "")}");
                return;
            }
            List<KeyValuePair<char, int>> myList = cntdict.ToList();
            myList.Sort(
                (pair1, pair2) => pair2.Value.CompareTo(pair1.Value)
            );
            var top1020 = string.Join("", myList.Skip(10).Take(10).Select(p => p.Key).ToArray());
            bool findbook = true;

            try
            {
                var book = context.Books.SingleOrDefault(p => p.TopIndexWords == top1020);
                if(book != null)
                {
                    Console.WriteLine($"Already exists: {fi.Name}");
                    return;
                }
                if (book == null)
                {
                    findbook = false;
                    book = new Book
                    {
                        Language = language,
                        LanguageId = language.LanguageId,
                        BookCategory = category,
                        BookCategoryId = category.BookCategoryId,
                        BookName = fi.Name.Replace(".txt", ""),
                        LastDateTime = DateTime.UtcNow,
                        BookInfo = string.Join('\n', lines.Skip(2).Take(5))
                    };
                }
                var br = new BookResult
                {
                    Book = book,
                    BookId = findbook ? book.BookId : 0,
                    Language = language,
                    ResultDateTime = DateTime.UtcNow,
                    WordCount = wc,
                    TotalCount = tc,
                    Top10 = string.Join("", myList.Take(10).Select(p => p.Key).ToArray()),
                    Top1020 = top1020,
                    Top50 = string.Join("", myList.Take(50).Select(p => p.Key).ToArray())
                };
                book.PrevWordCount = book.LastWordCount;
                book.PrevTotalCount = book.LastTotalCount;
                book.LastWordCount = wc;
                book.LastTotalCount = tc;
                if (findbook) context.Update(book);
                else
                {
                    book.TopIndexWords = br.Top1020;
                    context.Add(book);
                }
                context.Add(br);
                // todo 2018年4月14日 利用缓存加快了10倍速度（比直接使用context.WordStatisticses.SingleOrDefault），
                // 但是带来了多个程序同时访问数据库带来的数据不一致问题。
                var wordsrepo = context.WordStatisticses.ToDictionary(p => p.WordUnicode, p => p);
                foreach (var dic in cntdict)
                {
                    context.Add(new WordResult
                    {
                        Book = book,
                        BookId = findbook ? book.BookId : 0,
                        WordCount = dic.Value,
                        WordLetter = dic.Key.ToString(),
                        WordUnicode = dic.Key
                    });
                    var wordsta = wordsrepo.FirstOrDefault(p => p.Key == dic.Key.ToString()).Value;
                    if (wordsta == null)
                    {
                        wordsta = new WordStatistics
                        {
                            WordUnicode = dic.Key.ToString(),
                            TotalBook = 1,
                            TotalWords = wc,
                            TotalOccur = dic.Value,
                            MaxRatio = (double)dic.Value / (double)wc,
                            MaxWords = wc,
                            MaxOccur = dic.Value
                        };
                        context.Add(wordsta);
                    }
                    else
                    {
                        wordsta.TotalBook += 1;
                        wordsta.MaxOccur = Math.Max(wordsta.MaxOccur, dic.Value);
                        wordsta.MaxWords = Math.Max(wordsta.MaxWords, wc);
                        wordsta.MaxRatio = Math.Max(wordsta.MaxRatio, (double)dic.Value / (double)wc);
                        wordsta.TotalOccur += dic.Value;
                        wordsta.TotalWords += wc;
                        //if (findbook) todo 这里的计算有误！
                        //{
                        //    wordsta.TotalOccur -= ?? not book.PrevWordCount;
                        //    wordsta.TotalWords -= ?? not book.PrevTotalCount;
                        //}
                        context.Update(wordsta);
                    }
                }
                context.SaveChanges();
                sw.Stop();
                ++TotalBook;
                TotalWords += wc;
                TotalTime += sw.ElapsedMilliseconds;
                Console.WriteLine(
                    $"{TotalBook}: Parse finished, total words: {tc}, different words: {wc}, average elapsed milliseconds: {(double) TotalTime / (double) TotalBook}, average words: {(double) TotalWords / (double) TotalBook}. {book.BookName}");
                int i = 0;
                foreach (var count in myList)
                {
                    if (i++ > 10)
                        break;
                    Console.WriteLine($"{i}: {count.Key}: {count.Value}");
                }
            }
            catch (Exception e)
            {
                context = Program.GetBookContext();
                context.Add(new BookException
                {
                    Top1020 = top1020,
                    ErrorMsg = e.ToString(),
                    BookInfo = fi.FullName
                });
                context.SaveChanges();
                Console.WriteLine($"{TotalBook}: Parse failed: {e}");
            }
        }

        private string GetLetters(string line, Language language)
        {
            StringBuilder builder = new StringBuilder(line.Length);
            // 简体汉字
            if (language.LanguageCode == "zh_CN")
            {
                foreach (var c in line)
                {
                    if (c > 0x4E00 && c < 0x9FCB)
                    {
                        builder.Append(c);
                    }
                }
            }
            return builder.ToString();
        }
    }
    class Program
    {
        /// <summary>
        /// 将文本数据读取到系统中。
        /// https://carlos.mendible.com/2016/07/11/step-by-step-dotnet-core-and-entity-framework-core/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // <program> <dir> <language>
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: <program> <dir(\"E:\\xiabook\")> <language(zh_CN|en_US)> <category(MordernChineseMasterwork|MordernEnglishMasterwork|AcientChineseMasterbook|MordernChineseChildren|...)>");
                return;
            }
            var datapath = args[0];//@"E:\xiabook";
            BookContext gContext = GetBookContext();
            var lang = gContext.Languages.SingleOrDefault(p => p.LanguageCode == args[1]);
            if (lang == null)
            {
                lang = new Language
                {
                    LanguageName = args[1],
                    LanguageCode = args[1],
                    LanguageType = gContext.Languages.Max(p => p.LanguageType) + 1
                };
                gContext.Add(lang);
                gContext.SaveChanges();
            }
            var cate = gContext.BookCategories.SingleOrDefault(p => p.CategoryType == args[2]);
            if (cate == null)
            {
                cate = new BookCategory
                {
                    CategoryType = args[2]
                };
                gContext.Add(cate);
                gContext.SaveChanges();
            }


            var parser = new Parser();
            DirSearch(datapath, s =>
            {
                if (s.EndsWith("rar"))
                {
                    UnRar(s);
                }
            });
            //DirSearch(datapath, s =>
            //{
            //    FileInfo fi = new FileInfo(s);
            //    var newname = fi.FullName.Replace("_下书网www.xiabook.com", "");
            //    File.Move(s, newname);
            //});
            DirSearch(datapath, s =>
            {
                parser.ReadTxtFile(s, lang, cate, gContext);
            });
        }

        public static BookContext GetBookContext()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            // Get the connection string
            string connectionString = configuration.GetConnectionString("BookContext");
            return BookContextFactory.Create(connectionString);
        }

        private static void UnRar(string filepath)
        {
            var fi = new FileInfo(filepath);
            // Microsoft.Win32 and System.Diagnostics namespaces are imported
            //Dim objRegKey As RegistryKey
            RegistryKey objRegKey;
            objRegKey = Registry.ClassesRoot.OpenSubKey("WinRAR\\Shell\\Open\\Command");
            // Windows 7 Registry entry for WinRAR Open Command

            // Dim obj As Object = objRegKey.GetValue("");
            Object obj = objRegKey.GetValue("");

            //Dim objRarPath As String = obj.ToString()
            string objRarPath = obj.ToString();
            objRarPath = objRarPath.Substring(1, objRarPath.Length - 7);

            objRegKey.Close();

            //Dim objArguments As String
            string objArguments;
            // in the following format
            // " X G:\Downloads\samplefile.rar G:\Downloads\sampleextractfolder\"
            objArguments = " X " + " " + filepath + " " + " " + fi.DirectoryName;

            // Dim objStartInfo As New ProcessStartInfo()
            ProcessStartInfo objStartInfo = new ProcessStartInfo();

            // Set the UseShellExecute property of StartInfo object to FALSE
            //Otherwise the we can get the following error message
            //The Process object must have the UseShellExecute property set to false in order to use environment variables.
            objStartInfo.UseShellExecute = false;
            objStartInfo.FileName = objRarPath;
            objStartInfo.Arguments = objArguments;
            objStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            objStartInfo.WorkingDirectory = fi.DirectoryName + "\\";

            //   Dim objProcess As New Process()
            Process objProcess = new Process();
            objProcess.StartInfo = objStartInfo;
            objProcess.Start();
            objProcess.WaitForExit();


            try
            {
                fi.Delete();
                if (fi.DirectoryName != null)
                {
                    DirectoryInfo di = new DirectoryInfo(fi.DirectoryName);
                    FileInfo[] urlfiles = di.GetFiles("*.url")
                        .Where(p => p.Extension == ".url").ToArray();
                    foreach (FileInfo file in urlfiles)
                    {
                        try
                        {
                            file.Attributes = FileAttributes.Normal;
                            File.Delete(file.FullName);
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                
            }
        }

        static void DirSearch(string sDir, Action<string> doAction)
        {
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    doAction(f);
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch(d, doAction);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
