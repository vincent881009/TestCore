using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class DayReportTotalFinance
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal? DepositOnline { get; set; }
        public decimal? DepositCompany { get; set; }
        public decimal? DepositAlipay { get; set; }
        public decimal? Withdraw { get; set; }
        public decimal? IncomeOther { get; set; }
        public decimal? ExpendOther { get; set; }
        public decimal? GameIn { get; set; }
        public decimal? GameOut { get; set; }
    }
}
