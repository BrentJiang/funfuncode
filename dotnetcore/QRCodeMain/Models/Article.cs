using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRCodeMain.Models
{
    public class QrCode
    {
        public int QrCodeId { get; set; }
        public string QrCodeRelativePath { get; set; }
        public Article Article { get; set; }
    }

    public class Article
    {
        public int QrCodeId { get; set; }
        public virtual QrCode QrCode { get; set; }
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
        public string UserName { get; internal set; }
        public List<Category> Categories { get; set; }
        public List<UserTag> UserTags { get; set; }
    }

    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
    }

    /// <summary>
    /// 系统支持的类别，每一个类别都实现了用户推荐
    /// </summary>
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
    }

    /// <summary>
    /// 用户自定义表情
    /// </summary>
    public class UserTag
    {
        public int UserTagId { get; set; }
        public string Title { get; set; }
    }

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
