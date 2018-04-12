using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QRCodeMain.Models.MyViewModels
{
    public class MyHomeViewModel
    {
        [DisplayName("名称")]
        public string Title { get; set; }
        [DisplayName("简介")]
        public string Content { get; set; }
        public List<Article> Articles { get; internal set; }
    }
}
