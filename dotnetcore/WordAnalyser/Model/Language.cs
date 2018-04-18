using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class Language
    {
        public Int64 LanguageId { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public Int64 LanguageType { get; set; }
    }
}
