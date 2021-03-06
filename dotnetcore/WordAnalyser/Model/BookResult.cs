﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WordAnalyser.Model
{
    /// <summary>
    /// 一次处理一本书的结果，包括处理的语言
    /// </summary>
    public class BookResult
    {
        public Int64 BookResultId { get; set; }
        public Int64 BookId { get; set; }
        public virtual Book Book { get; set; }
        public Int64 LanguageId { get; set; }
        /// <summary>
        /// 词汇量
        /// </summary>
        public Int64 WordCount { get; set; }
        /// <summary>
        /// 字数
        /// </summary>
        public Int64 TotalCount { get; set; }
        public DateTime ResultDateTime { get; set; }
        /// <summary>
        /// 处理分析器信息，例如词库信息等。
        /// </summary>
        public string ParserInfo { get; set; }
        public string Top10 { get; set; }
        [StringLength(100)]
        public string Top1020 { get; set; }
        public string Top50 { get; set; }
        public Int64 BookTrack { get; set; }
    }
}
