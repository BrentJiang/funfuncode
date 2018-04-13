using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class Word
    {
        public Int64 WordId { get; set; }
        public int LanguageType { get; set; }
        public string WordBrief { get; set; }
        public int WordUnicode { get; set; }
    }
}
