using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class BakFinanceAccess20181015
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
    }
}
