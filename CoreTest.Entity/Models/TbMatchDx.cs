using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbMatchDx
    {
        public int Gid { get; set; }
        public string RatioO { get; set; }
        public string RatioU { get; set; }
        public double? IorOuh { get; set; }
        public double? IorOuc { get; set; }
        public string HratioO { get; set; }
        public string HratioU { get; set; }
        public double? IorHouh { get; set; }
        public double? IorHouc { get; set; }
        public string RatioOuho { get; set; }
        public string RatioOuhu { get; set; }
        public double? IorOuho { get; set; }
        public double? IorOuhu { get; set; }
        public string RatioOuco { get; set; }
        public string RatioOucu { get; set; }
        public double? IorOuco { get; set; }
        public double? IorOucu { get; set; }
        public int Type { get; set; }
    }
}
