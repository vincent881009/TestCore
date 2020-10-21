using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class AppOrderAll
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Code { get; set; }
        public string GroupCode { get; set; }
        public string Type { get; set; }
        public string OrderType { get; set; }
        public string PlayType { get; set; }
        public string Status { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TuishuiAmount { get; set; }
        public decimal? ValidAmount { get; set; }
        public decimal? WinAmount { get; set; }
        public decimal? Odds { get; set; }
        public string Score { get; set; }
        public string ContextExt { get; set; }
    }
}
