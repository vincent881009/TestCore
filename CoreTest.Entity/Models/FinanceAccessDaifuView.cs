using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class FinanceAccessDaifuView
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Openbank { get; set; }
        public string BankCode { get; set; }
        public string OpenName { get; set; }
        public string OpenBankAddr { get; set; }
        public decimal? AccessBeforeAmount { get; set; }
        public decimal? AccessAfterAmount { get; set; }
        public decimal? AccessAmount { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public string Remark { get; set; }
        public string SubType { get; set; }
        public string Source { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string RemarkAdmin { get; set; }
        public int? DepositWithdrawNum { get; set; }
        public int? Quantity { get; set; }
        public string LoginNameUserName { get; set; }
        public string Qcode { get; set; }
        public string Outcode { get; set; }
        public decimal? Amt { get; set; }
        public DateTime? SubmitTime2 { get; set; }
        public string SubmitUser { get; set; }
        public string Status2 { get; set; }
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public string AccBank { get; set; }
        public string AccBankName { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string AccMobile { get; set; }
        public string OrderStatusMsg { get; set; }
        public string UserLeve { get; set; }
    }
}
