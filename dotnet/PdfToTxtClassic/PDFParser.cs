using System.IO;
using IFilterTextReader;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;

namespace PdfToTxtClassic
{
    internal class PDFParser
    {
        public void ExtractText(string inpufFileName, string outputFileName)
        {
#if false
            IFilterTextReader.FilterReader reader = new FilterReader(inpufFileName);
            var data = reader.ReadToEnd();
            using (var writer = new StreamWriter(outputFileName, false, System.Text.Encoding.UTF8))
            {
                writer.Write(data);
            }
#else
            PDDocument doc = null;
            try
            {
                doc = PDDocument.load(inpufFileName);
                PDFTextStripper stripper = new PDFTextStripper();
                using (var writer = new StreamWriter(outputFileName, false, System.Text.Encoding.UTF8))
                {
                    writer.Write(stripper.getText(doc));
                }
            }
            finally
            {
                if (doc != null)
                {
                    doc.close();
                }
            }
#endif
        }
    }
}