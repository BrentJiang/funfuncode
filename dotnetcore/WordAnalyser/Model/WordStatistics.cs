using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class WordStatistics
    {
        public int WordStatisticsId { get; set; }
        public string WordUnicode { get; set; }
        /// <summary>
        /// 出现过该文字的书籍数量
        /// </summary>
        public int TotalBook { get; set; }
        /// <summary>
        /// 出现过该字的文字量最大的一本书里面的文字量
        /// </summary>
        public int TotalWords { get; set; }
        /// <summary>
        /// 出现过该文字的所有书里面该文字的出现次数总和
        /// </summary>
        public int TotalOccur { get; set; }
        /// <summary>
        /// 出现过该字的词汇量最大的一本书里面的词汇量
        /// </summary>
        public int MaxWords { get; set; }
        /// <summary>
        /// 出现过该文字次数做多的一本书里面该文字的出现次数
        /// </summary>
        public int MaxOccur { get; set; }
        /// <summary>
        /// 出现过该文字次数做多的一本书里面该文字的出现比率
        /// </summary>
        public double MaxRatio { get; set; }
    }
}
