using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    /// <summary>
    /// 不与Word表直接关联，这样可以不依赖于是否收纳了该词汇。
    /// </summary>
    public class WordResult
    {
        public Int64 WordResultId { get; set; }
        public string WordLetter { get; set; }
        public int WordUnicode { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int WordCount { get; set; }
    }
}
