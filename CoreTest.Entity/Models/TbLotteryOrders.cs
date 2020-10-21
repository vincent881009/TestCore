using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbLotteryOrders
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string LotteryName { get; set; }
        public string ButchNo { get; set; }
        public string LoginName { get; set; }
        public decimal? OrderMoney { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public decimal? SettleMoney { get; set; }
        public string PrizeData { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public decimal? TheoryMoney { get; set; }
        public decimal? TuishuiAmount { get; set; }
        public bool? Ischuan { get; set; }
        public string CreteSource { get; set; }
        public string Remark { get; set; }
    }
}
