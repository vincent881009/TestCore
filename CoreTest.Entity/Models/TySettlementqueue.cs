using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TySettlementqueue
    {
        public Guid Id { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Source { get; set; }
        public string Sysuser { get; set; }
    }
}
