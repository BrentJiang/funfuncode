using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    /// <summary>
    /// 一本书，只能统计为一种语言。
    /// </summary>
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookInfo { get; set; }
        public DateTime LastDateTime { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int PrevWordCount { get; set; }
        /// <summary>
        /// 用于快速进行多本书统计计算
        /// </summary>
        public int LastWordCount { get; set; }
    }
}
