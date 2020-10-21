using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class AgentMouthReport
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public DateTime? Date { get; set; }
        public int? UserCount { get; set; }
        public decimal? Lotteryamount { get; set; }
        public decimal? Ballamount { get; set; }
        public decimal? Sumamount { get; set; }
        public decimal? LotteryResultAmount { get; set; }
        public decimal? BallResultAmount { get; set; }
        public decimal? GainAmount { get; set; }
        public decimal? LotterySetAmount { get; set; }
        public decimal? BallSetAmount { get; set; }
        public decimal? SumSetAmount { get; set; }
        public decimal? YouxiaoAmount { get; set; }
        public decimal? YouxiaoAmount2 { get; set; }
        public decimal? GameBetamount { get; set; }
        public decimal? GameValidamount { get; set; }
        public decimal? Gameset { get; set; }
    }
}
