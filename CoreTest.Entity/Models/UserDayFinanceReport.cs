using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserDayFinanceReport
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public DateTime? Date { get; set; }
        public decimal? DayDeposit { get; set; }
        public decimal? DayWithdraw { get; set; }
        public int? SportOrderNum { get; set; }
        public decimal? SportOrderAmount { get; set; }
        public decimal? SportOrderResultAmount { get; set; }
        public decimal? SportTuiShuiAmount { get; set; }
        public int? LotteryOrderNum { get; set; }
        public decimal? LotteryOrderAmount { get; set; }
        public decimal? LotteryOrderResultAmount { get; set; }
        public decimal? LotteryTuShuiAmount { get; set; }
        public decimal? GameAmount { get; set; }
        public decimal? GameResultAmount { get; set; }
        public decimal? GameTuiShuiAmount { get; set; }
    }
}
