using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class Score
    {
        public Guid Id { get; set; }
        public Guid? MatchId { get; set; }
        public string Type { get; set; }
        public double? Host { get; set; }
        public double? Ting { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public string Status { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
    }
}
