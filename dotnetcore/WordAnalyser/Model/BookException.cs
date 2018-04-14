using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class BookException
    {
        public int BookExceptionId { get; set; }
        public string Top1020 { get; set; }
        public string ErrorMsg { get; set; }
        public string BookInfo { get; set; }
    }
}
