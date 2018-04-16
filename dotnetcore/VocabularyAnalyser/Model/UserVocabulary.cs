using System;
using System.Collections.Generic;
using System.Text;

namespace VocabularyAnalyser.Model
{
    /// <brief>
    /// zh_CN,..., 不直接与WordAnalyser.Model.Language相关。通过独立工具为每一个用户
    /// 创建或持续更新UserVocabulary。
    /// </brief>
    public class UserVocabulary
    {
        public int UserVocabularyId { get; set; }
        // index,
        public string WordUnicode { get; set; }
        // zh_CN,..., 不直接与WordAnalyser.Model.Language相关。通过独立工具为每一个用户
        // 创建或持续更新UserVocabulary。
        public string LanguageCode { get; set; }
        public int TestTimes { get; set; }
        public int WrongTimes { get; set; }
        /// <summary>
        /// 用于快速判断是否需要随机选择进行考核,一般小于等于0就是需要考核的。
        /// 测试一次成功+1，失败-1。
        /// </summary>
        public int CriticalTimes { get; set; }
    }

    public class VocabularyTestDetail
    {
        public int VocabularyTestDetailId { get; set; }
        public int VocabularyTestId { get; set; }
        public virtual VocabularyTest VocabularyTest { get; set; }
        // index,
        public string WordUnicode { get; set; }
        // zh_CN,..., 不直接与WordAnalyser.Model.Language相关。通过独立工具为每一个用户
        // 创建或持续更新UserVocabulary。
        public string LanguageCode { get; set; }
        public string AnswerContent { get; set; }
        /// <summary>
        /// 标准答案
        /// </summary>
        public int CorrectAnswer { get; set; }
        /// <summary>
        /// 1,2,3,4,...表示回答结果A、B、C、D等
        /// </summary>
        public int FinalAnswer { get; set; }
    }

    public class VocabularyTest
    {
        public int VocabularyTestId { get; set; }
        public string UserName { get; set; }
        public List<VocabularyTestDetail> VocabularyTestDetails { get; set; }
    }
}
