using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class VApibbetUserDataExByProvider
    {
        public long? Id { get; set; }
        public string MemberName { get; set; }
        public DateTime? TimeChn { get; set; }
        public decimal? BetAmount { get; set; }
        public decimal? ValidAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public string Provider { get; set; }
    }
}
