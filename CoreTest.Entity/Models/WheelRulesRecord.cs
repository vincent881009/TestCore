using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class WheelRulesRecord
    {
        public Guid Id { get; set; }
        public string FinanceAccessId { get; set; }
        public string LoginName { get; set; }
        public string PayType { get; set; }
        public decimal? AccessAmount { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Count { get; set; }
        public string Expression { get; set; }
        public int? LeijiCount { get; set; }
    }
}
