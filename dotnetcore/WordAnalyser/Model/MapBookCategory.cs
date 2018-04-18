using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class MapBookCategory
    {
        public Int64 MapBookCategoryId { get; set; }
        public Int64 BookCategoryId { get; set; }
        public virtual BookCategory BookCategory { get; set; }
        public Int64 BookId { get; set; }
        public virtual Book Book{ get; set; }
    }
}
