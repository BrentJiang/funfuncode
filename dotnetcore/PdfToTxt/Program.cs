using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace PdfToTxt
{
    class Program
    {
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

        static void Main(string[] args)
        {
            PDFParser pdfParser = new PDFParser();

            DirSearch(args[0], filename =>
            {
                if (!filename.EndsWith(".pdf"))
                    return;

                if (File.Exists(filename.Replace(".pdf", ".txt")))
                    return;

                Console.WriteLine("\n" + filename);
                pdfParser.ExtractText(filename, filename + ".txt");

                // parse papers
                List<string> results = new List<string>();
                string prevline = string.Empty;
                bool needremoveminus = false;
                string next = string.Empty;
                foreach (var rawline in File.ReadAllLines(filename + ".txt"))
                {
                    var line = rawline.Replace("220", "'").Replace("215", "\"").Replace("216", "\"").Replace("204", "--");
                    // remove empty lines
                    if (string.IsNullOrEmpty(line.Trim()))
                        continue;

                    if (line.EndsWith('-'))
                    {
                        line = line.Substring(0, line.Length - 1);
                    }

                    if ((!string.IsNullOrEmpty(prevline) && !char.IsLetter(prevline.Last()))
                        || char.IsUpper(line.TrimStart()[0]))
                    {
                        if (prevline.Length > 0)
                            results.Add(prevline);
                        prevline = line;
                        needremoveminus = false;
                    }
                    else
                    {
                        prevline += line;
                        needremoveminus = true;
                    }
                }
                if (!string.IsNullOrEmpty(prevline))
                    results.Add(prevline);

                File.WriteAllLines(filename + ".parsed.txt", results);
            });


        }
    }
}
