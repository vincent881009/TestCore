using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class SettlementJob
    {
        public Guid Id { get; set; }
        public string LotteryName { get; set; }
        public string ButchNo { get; set; }
        public string Status { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? PublishDate { get; set; }
    }
}
