using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using WordAnalyser.Model;

namespace BookReader
{
    /// <summary>
    /// 仅从目前有的字库中进行统计
    /// </summary>
    class Parser
    {
        private double TotalTime = 0;
        private int TotalBook = 0;
        private Int64 TotalWords = 0;
        public void ReadTxtFile(string filePathName, Language language, BookContext context, int? bookId)
        {
            var sw = new Stopwatch();
            Book book = null;

            if (bookId == null)
            {
                var fi = new FileInfo(filePathName);
                if (fi.Extension != ".txt")
                    return;
                book = new Book
                {
                    Language = language,
                    LanguageId = language.LanguageId,
                    BookName = fi.Name.Replace(".txt", ""),
                    LastDateTime = DateTime.UtcNow,
                    BookInfo = $"read from {filePathName}"
                };
                context.Add(book);
                context.SaveChanges();
            }

            sw.Start();
            var lines = File.ReadLines(filePathName);
            var cntdict = new Dictionary<char, int>();
            int wc = 0;
            int tc = 0;
            foreach (var line in lines)
            {
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

            var br = new BookResult()
            {
                Book = book,
                BookId = book.BookId,
                Language = language,
                ResultDateTime = DateTime.UtcNow,
                WordCount = wc,
                TotalCount = tc
            };
            context.BookResults.Add(br);
            foreach (var i in cntdict)
            {
                context.WordResults.Add(new WordResult()
                {
                    Book = book,
                    BookId = book.BookId,
                    WordCount = i.Value,
                    WordLetter = i.Key.ToString(),
                    WordUnicode = i.Key
                });
            }
            try
            {
                context.SaveChanges();
                sw.Stop();
                ++TotalBook;
                TotalWords += wc;
                TotalTime += sw.ElapsedMilliseconds;
                Console.WriteLine(
                    $"Parse finished, total words: {tc}, different words: {wc}, average elapsed milliseconds: {(double) TotalTime / (double) TotalBook}, average words: {(double) TotalWords / (double) TotalBook}");
                List<KeyValuePair<char, int>> myList = cntdict.ToList();
                myList.Sort(
                    delegate (KeyValuePair<char, int> pair1,
                        KeyValuePair<char, int> pair2)
                    {
                        return pair2.Value.CompareTo(pair1.Value);
                    }
                );
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
                Console.WriteLine(e);
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
        /// https://carlos.mendible.com/2016/07/11/step-by-step-dotnet-core-and-entity-framework-core/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // <program> <file> <language>
            if (args.Length != 2)
                return;
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            // Get the connection string
            string connectionString = configuration.GetConnectionString("BookContext");
            BookContext gContext = BookContextFactory.Create(connectionString);
            var lang = gContext.Languages.SingleOrDefault(p => p.LanguageCode == args[1]);
            if (lang == null)
            {
                lang = new Language()
                {
                    LanguageName = "简体中文",
                    LanguageCode = "zh_CN",
                    LanguageType = 1
                };
                gContext.Languages.Add(lang);
                gContext.SaveChanges();
            }


            var parser = new Parser();
            DirSearch(args[0], s =>
            {
                if (s.EndsWith("rar"))
                {
                    UnRar(s);
                }
            });
            DirSearch(args[0], s =>
            {
                FileInfo fi = new FileInfo(s);
                var newname = fi.FullName.Replace("_下书网www.xiabook.com", "");
                File.Move(s, newname);
            });
            DirSearch(args[0], s =>
            {
                parser.ReadTxtFile(s, lang, gContext, null);
            });
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
