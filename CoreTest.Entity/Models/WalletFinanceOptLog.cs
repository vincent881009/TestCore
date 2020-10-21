using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class WalletFinanceOptLog
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public decimal? Money { get; set; }
        public string Type { get; set; }
        public decimal? CalcBeforeMoney { get; set; }
        public decimal? CalcAfterMoney { get; set; }
        public DateTime? CreateTime { get; set; }
        public string OptUser { get; set; }
    }
}
