using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class FinanceSum
    {
        public string LoginName { get; set; }
        public DateTime? Date { get; set; }
        public decimal? DepositCompany { get; set; }
        public decimal? DepositAlipay { get; set; }
        public decimal? DepositQqpay { get; set; }
        public decimal? DepositWeixin { get; set; }
        public decimal? IncomeOther { get; set; }
        public decimal? OutcomeOther { get; set; }
        public decimal Caijin { get; set; }
        public decimal DepositHongbao { get; set; }
        public decimal DepositOnline { get; set; }
        public decimal ZrTuishui { get; set; }
        public decimal Withdraw { get; set; }
        public decimal Present { get; set; }
        public decimal Ylsm { get; set; }
        public decimal? WheelAmount { get; set; }
    }
}
