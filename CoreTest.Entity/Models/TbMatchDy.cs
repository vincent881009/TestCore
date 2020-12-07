using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbMatchDy
    {
        public int Gid { get; set; }
        public double? IorMh { get; set; }
        public double? IorMc { get; set; }
        public double? IorMn { get; set; }
        public double? IorHmh { get; set; }
        public double? IorHmc { get; set; }
        public double? IorHmn { get; set; }
        public int Type { get; set; }
    }
}
