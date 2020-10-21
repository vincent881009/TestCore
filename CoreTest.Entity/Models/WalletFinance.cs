using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class WalletFinance
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public decimal? Money { get; set; }
        public decimal? LastDayInCome { get; set; }
    }
}
