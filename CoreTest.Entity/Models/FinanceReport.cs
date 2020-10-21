using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class FinanceReport
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public decimal? AccessAfterAmount { get; set; }
        public decimal? AccessAmountIn { get; set; }
        public decimal? AccessAmountOut { get; set; }
        public DateTime? CraeteData { get; set; }
    }
}
