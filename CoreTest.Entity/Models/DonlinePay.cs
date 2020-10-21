using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class DonlinePay
    {
        public string Code { get; set; }
        public string LoginName { get; set; }
        public string Qcode { get; set; }
        public string Outcode { get; set; }
        public decimal? Amt { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string SubmitUser { get; set; }
        public string Status { get; set; }
        public DateTime? LastcallbackTime { get; set; }
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public string AccBank { get; set; }
        public string AccBankName { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string AccMobile { get; set; }
        public string OrderStatusMsg { get; set; }
        public string Rid { get; set; }
    }
}
