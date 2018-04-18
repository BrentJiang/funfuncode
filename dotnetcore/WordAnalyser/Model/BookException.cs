using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class BookException
    {
        public Int64 BookExceptionId { get; set; }
        public string Top1020 { get; set; }
        public string ErrorMsg { get; set; }
        public string BookInfo { get; set; }
    }
}
