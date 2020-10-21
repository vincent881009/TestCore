using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserVedioGameDayReport
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Provider { get; set; }
        public DateTime? CreateTime { get; set; }
        public decimal? RealBetamount { get; set; }
        public decimal? RealValidamount { get; set; }
        public decimal? RealNetamount { get; set; }
        public decimal? RealTsamount { get; set; }
        public decimal? EgBetamount { get; set; }
        public decimal? EgValidamount { get; set; }
        public decimal? EgNetamount { get; set; }
        public decimal? EgTsamount { get; set; }
        public decimal? LotteryBetamount { get; set; }
        public decimal? LotteryValidamount { get; set; }
        public decimal? LotteryNetamount { get; set; }
        public decimal? LotteryTsamount { get; set; }
        public decimal? SportBetamount { get; set; }
        public decimal? SportValidamount { get; set; }
        public decimal? SportNetamount { get; set; }
        public decimal? SportTsamount { get; set; }
        public decimal? TotalBetamount { get; set; }
        public decimal? TotalValidamount { get; set; }
        public decimal? TotalNetamount { get; set; }
        public decimal? TotalTsamount { get; set; }
        public decimal? VedioRate { get; set; }
        public decimal? GameRate { get; set; }
        public decimal? SportRate { get; set; }
        public decimal? LotteryRate { get; set; }
    }
}
