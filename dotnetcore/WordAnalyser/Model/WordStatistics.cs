using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WordAnalyser.Model
{
    public class WordStatistics
    {
        public Int64 WordStatisticsId { get; set; }
        // see https://en.wikipedia.org/wiki/Longest_word_in_English
        // only 5 words longer than 30.
        [StringLength(30)]
        public string WordUnicode { get; set; }
        public Int64 WordLength { get; set; }
        /// <summary>
        /// 出现过该文字的书籍数量
        /// </summary>
        public Int64 TotalBook { get; set; }
        /// <summary>
        /// 出现过该字的文字量最大的一本书里面的文字量
        /// </summary>
        public Int64 TotalWords { get; set; }
        /// <summary>
        /// 出现过该文字的所有书里面该文字的出现次数总和
        /// </summary>
        public Int64 TotalOccur { get; set; }
        /// <summary>
        /// 出现过该字的词汇量最大的一本书里面的词汇量
        /// </summary>
        public Int64 MaxWords { get; set; }
        /// <summary>
        /// 出现过该文字次数做多的一本书里面该文字的出现次数
        /// </summary>
        public Int64 MaxOccur { get; set; }
        /// <summary>
        /// 出现过该文字次数做多的一本书里面该文字的出现比率
        /// </summary>
        public double MaxRatio { get; set; }

        /// <summary>
        /// 2018年4月15日 增加文字统计中的书籍分类信息。这样如果单纯的表格数据迁移时，
        /// 可以根据图书分类进行。
        /// </summary>
        public Int64 BookCategoryId { get; set; }
        public virtual BookCategory BookCategory { get; set; }
        public Int64 FirstBookId { get; set; }
    }
}
