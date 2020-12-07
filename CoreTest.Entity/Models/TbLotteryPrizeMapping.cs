using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbLotteryPrizeMapping
    {
        public Guid Id { get; set; }
        public string LotteryName { get; set; }
        public int? Point1 { get; set; }
        public int? Point2 { get; set; }
        public int? Point3 { get; set; }
        public int? Point4 { get; set; }
        public int? Point5 { get; set; }
        public string OddsName { get; set; }
    }
}
