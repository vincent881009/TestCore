using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class VedioGameDayReport
    {
        public Guid Id { get; set; }
        public DateTime? ReportDay { get; set; }
        public decimal? AgBetamount { get; set; }
        public decimal? AgValidamount { get; set; }
        public decimal? AgNetamount { get; set; }
        public decimal? AgTsamount { get; set; }
        public decimal? BbinBetamount { get; set; }
        public decimal? BbinValidamount { get; set; }
        public decimal? BbinNetamount { get; set; }
        public decimal? BbinTsamount { get; set; }
        public decimal? HgBetamount { get; set; }
        public decimal? HgValidamount { get; set; }
        public decimal? HgNetamount { get; set; }
        public decimal? HgTsamount { get; set; }
        public decimal? AllbetBetamount { get; set; }
        public decimal? AllbetValidamount { get; set; }
        public decimal? AllbetNetamount { get; set; }
        public decimal? AllbetTsamount { get; set; }
        public decimal? PtBetamount { get; set; }
        public decimal? PtValidamount { get; set; }
        public decimal? PtNetamount { get; set; }
        public decimal? PtTsamount { get; set; }
        public decimal? TotalBetamount { get; set; }
        public decimal? TotalValidamount { get; set; }
        public decimal? TotalNetamount { get; set; }
        public decimal? TotalTsamount { get; set; }
    }
}
