using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class FinanceRemittance
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string LoginName { get; set; }
        public decimal? RemittanceBeforeAmount { get; set; }
        public decimal? RemittanceAfterAmount { get; set; }
        public decimal? RemittanceAmount { get; set; }
        public DateTime? RemittanceDate { get; set; }
        public string RemittanceBankName { get; set; }
        public string RemittanceType { get; set; }
        public string RemittanceAddr { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Status { get; set; }
        public bool? IsFree { get; set; }
    }
}
