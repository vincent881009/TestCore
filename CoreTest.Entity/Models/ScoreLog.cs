using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class ScoreLog
    {
        public Guid Id { get; set; }
        public int Gid { get; set; }
        public int? H { get; set; }
        public int? C { get; set; }
        public int? Redh { get; set; }
        public int? Redc { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
