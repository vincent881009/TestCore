using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class Odds
    {
        public Guid Id { get; set; }
        public Guid? MatchId { get; set; }
        public string Type { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public double? Odds1 { get; set; }
        public double? Additional { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
    }
}
