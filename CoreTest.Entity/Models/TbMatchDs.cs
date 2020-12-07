using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbMatchDs
    {
        public int Gid { get; set; }
        public string StrOdd { get; set; }
        public string StrEven { get; set; }
        public double? IorEoo { get; set; }
        public double? IorEoe { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int Type { get; set; }
    }
}
