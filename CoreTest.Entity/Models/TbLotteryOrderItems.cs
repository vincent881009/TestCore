using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbLotteryOrderItems
    {
        public int ID { get; set; }
        public Guid? OrderId { get; set; }
        public string OddsGroupName { get; set; }
        public string OddsName { get; set; }
        public decimal? PointsOdds { get; set; }
        public decimal? ItemMoney { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
        public decimal? TheoryMoney { get; set; }
        public int? Sort { get; set; }
    }
}
