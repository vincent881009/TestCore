using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbLotteryOdds
    {
        public Guid Id { get; set; }
        public string LotteryName { get; set; }
        public string HroupName { get; set; }
        public string OddsName { get; set; }
        public double? PointsOdds { get; set; }
        public string Status { get; set; }
        public int? ShowIndex { get; set; }
    }
}
