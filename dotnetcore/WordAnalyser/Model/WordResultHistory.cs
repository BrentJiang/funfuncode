﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WordAnalyser.Model
{
    public class WordResultHistory : WordResult
    {
        public Int64 WordResultHistoryId { get; set; }
        public DateTime ArchiveDateTime { get; set; }
    }
}
