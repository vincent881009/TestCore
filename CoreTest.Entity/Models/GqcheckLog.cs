using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class GqcheckLog
    {
        public Guid OrderId { get; set; }
        public string OrderView { get; set; }
        public string MatchView { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
