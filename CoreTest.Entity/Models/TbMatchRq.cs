using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbMatchRq
    {
        public int Gid { get; set; }
        public string Ratio { get; set; }
        public double? IorRh { get; set; }
        public double? IorRc { get; set; }
        public string Hratio { get; set; }
        public double? IorHrh { get; set; }
        public double? IorHrc { get; set; }
        public int Type { get; set; }
    }
}
