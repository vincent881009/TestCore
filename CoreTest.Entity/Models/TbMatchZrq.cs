using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbMatchZrq
    {
        public int Gid { get; set; }
        public double? IorOdd { get; set; }
        public double? IorEven { get; set; }
        public double? IorT01 { get; set; }
        public double? IorT23 { get; set; }
        public double? IorT46 { get; set; }
        public double? IorOver { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int Type { get; set; }
    }
}
