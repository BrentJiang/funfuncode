using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WordAnalyser.Model
{
    /// <summary>
    /// 每一次添加一本书都进行登记，避免Top1020重复后Book表中记录被冲掉。
    /// </summary>
    public class BookTrack
    {
        public Int64 BookTrackId { get; set; }
        [StringLength(100)]
        public string Top1020 { get; set; }
        /// <summary>
        /// 获取文件的路径和名称。
        /// </summary>
        public string OriginalPath { get; set; }

        public string BookInfo { get; set; }
    }
}
