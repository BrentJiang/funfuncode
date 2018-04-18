using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class Word
    {
        public Int64 WordId { get; set; }
        public Int64 LanguageType { get; set; }
        public string WordBrief { get; set; }
        public Int64 WordUnicode { get; set; }
    }
}
