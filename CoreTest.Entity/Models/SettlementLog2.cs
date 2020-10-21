using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class SettlementLog2
    {
        public Guid Id { get; set; }
        public string OrderCode { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Source { get; set; }
        public string Content { get; set; }
        public string SysuerName { get; set; }
    }
}
