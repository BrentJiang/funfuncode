using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QRCodeMain.Models.WordStatisticsViewModels
{
    public class NewTestViewModel
    {
        [Display(Name = "考试词汇量范围:")]
        public int TestScopeWordCount { get; set; }
        [Display(Name = "考试题目数量:")]
        public int TestWordCount { get; set; }
    }
}
