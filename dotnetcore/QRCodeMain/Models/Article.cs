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
        public QrCode QrCode { get; set; }
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
    }
}
