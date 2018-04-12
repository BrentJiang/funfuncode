using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRCodeMain.Models.MyViewModels
{
    public class ArticleViewModel
    {
        public Article Article { get; set; }
        public List<Category> SystemCategories { get; set; }
    }
}
