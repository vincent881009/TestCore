using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserFinance
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public Guid? Rid { get; set; }
        public string LoginName { get; set; }
        public decimal? AccessBeforeAmount { get; set; }
        public decimal? AccessAfterAmount { get; set; }
        public decimal? AccessAmount { get; set; }
        public DateTime? CraeteData { get; set; }
        public string WebRemark { get; set; }
        public string Remark { get; set; }
        public string Code { get; set; }
    }
}
