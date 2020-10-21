using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class OptSettlementLog
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public Guid? OrderId { get; set; }
        public string OrderCode { get; set; }
        public string LoginName { get; set; }
        public decimal? OrderMoney { get; set; }
        public decimal? ResultMoney { get; set; }
        public string CurrentScore { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime? OptTime { get; set; }
        public DateTime? OrderTime { get; set; }
    }
}
