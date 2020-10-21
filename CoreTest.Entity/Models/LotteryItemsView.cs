using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class LotteryItemsView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string LotteryName { get; set; }
        public string ButchNo { get; set; }
        public string LoginName { get; set; }
        public decimal? OrderMoney { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public decimal? SettleMoney { get; set; }
        public decimal? TuishuiAmount { get; set; }
        public string CreteSource { get; set; }
        public string OddsGroupName { get; set; }
        public string OddsName { get; set; }
        public string Ext1 { get; set; }
        public decimal? PointsOdds { get; set; }
        public decimal? ItemMoney { get; set; }
        public decimal? TheoryMoney { get; set; }
    }
}
