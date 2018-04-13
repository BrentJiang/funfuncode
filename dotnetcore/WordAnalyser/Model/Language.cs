using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public int LanguageType { get; set; }
    }
}
