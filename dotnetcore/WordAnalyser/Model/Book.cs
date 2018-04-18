using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WordAnalyser.Model
{
    /// <summary>
    /// 一本书，只能统计为一种语言。但是图书不与分类直接关联。
    /// </summary>
    public class Book
    {
        public Int64 BookId { get; set; }
        public string BookName { get; set; }
        public string BookInfo { get; set; }
        public DateTime LastDateTime { get; set; }
        public Int64 LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public Int64 PrevWordCount { get; set; }
        /// <summary>
        /// 用于快速进行多本书统计计算
        /// </summary>
        public Int64 LastWordCount { get; set; }
        [StringLength(100)]
        public string TopIndexWords { get; set; }
        public Int64 LastTotalCount { get; set; }
        public Int64 PrevTotalCount { get; set; }
    }
}
