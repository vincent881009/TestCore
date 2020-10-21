using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbLotterySettlementLog
    {
        public Guid Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string PrizeData { get; set; }
        public Guid? OrderId { get; set; }
        public int? OrderItemId { get; set; }
        public string Code { get; set; }
        public string LotteryName { get; set; }
        public string ButchNo { get; set; }
        public string OddsGroupName { get; set; }
        public string OddsName { get; set; }
        public decimal? PointsOdds { get; set; }
        public decimal? ItemMoney { get; set; }
        public decimal? ItemsettleMoney { get; set; }
        public string Remark { get; set; }
    }
}
