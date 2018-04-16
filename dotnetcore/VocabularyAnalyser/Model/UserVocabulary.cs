using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VocabularyAnalyser.Model
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public int LanguageType { get; set; }
    }
    public class MyVocabularyStatistics
    {
        public int MyVocabularyStatisticsId { get; set; }
        public string UserName { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public double CurrentScore { get; set; }
        public int TotalTestCount { get; set; }
    }
    /// <brief>
    /// zh_CN,..., 不直接与WordAnalyser.Model.Language相关。通过独立工具为每一个用户
    /// 创建或持续更新UserVocabulary。
    /// </brief>
    public class UserVocabulary
    {
        public int UserVocabularyId { get; set; }
        public string UserName { get; set; }
        // index,
        public string WordUnicode { get; set; }
        // zh_CN,..., 不直接与WordAnalyser.Model.Language相关。通过独立工具为每一个用户
        // 创建或持续更新UserVocabulary。
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int TestTimes { get; set; }
        public int WrongTimes { get; set; }
        /// <summary>
        /// 用于快速判断是否需要随机选择进行考核,一般小于等于0就是需要考核的。
        /// 测试一次成功+1，失败-1。
        /// </summary>
        public int CriticalTimes { get; set; }
    }

    public class MyVocabularyTest
    {
        public int MyVocabularyTestId { get; set; }
        public string UserName { get; set; }
        [Display(Name = "考试题目数量:")]
        public int TestWordCount { get; set; }
        public virtual List<VocabularyTestDetail> VocabularyTestDetails { get; set; }
        public DateTime TestTime { get; set; }
        public double Score { get; set; }
        public int CorrectWordCount { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }

    public class VocabularyTestDetail
    {
        public int VocabularyTestDetailId { get; set; }
        public int VocabularyTestId { get; set; }
        public virtual MyVocabularyTest VocabularyTest { get; set; }
        // index,
        public string WordUnicode { get; set; }
        // zh_CN,..., 不直接与WordAnalyser.Model.Language相关。通过独立工具为每一个用户
        // 创建或持续更新UserVocabulary。
        public string LanguageCode { get; set; }
        public string AnswerContentA { get; set; }
        public string AnswerContentB { get; set; }
        public string AnswerContentC { get; set; }
        public string AnswerContentD { get; set; }
        /// <summary>
        /// 标准答案
        /// </summary>
        public char CorrectAnswer { get; set; }
        /// <summary>
        /// 1,2,3,4,...表示回答结果A、B、C、D等
        /// </summary>
        public char FinalAnswer { get; set; } = ' ';
    }
}
