using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VocabularyAnalyser.Model;

namespace QRCodeMain.Models.MyStatisticsViewModels
{
    public class MyStatisticsViewModel
    {
        public Language Language { get; set; }
        /// <summary>
        /// 词汇量汇总信息
        /// </summary>
        public MyVocabularyStatistics MyVocabulary { get; set; }
        public List<MyVocabularyTest> MyTestsLatest { get; set; }
    }
}
