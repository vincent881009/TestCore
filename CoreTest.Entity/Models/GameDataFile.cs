using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class GameDataFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public long? FileSize { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public bool? NeedUpdate { get; set; }
    }
}
