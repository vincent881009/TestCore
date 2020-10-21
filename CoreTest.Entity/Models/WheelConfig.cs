using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class WheelConfig
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Phone { get; set; }
        public int? TotalLimit { get; set; }
        public int? UseLimit { get; set; }
        public int? UsedLimit { get; set; }
        public int? DepositeA { get; set; }
        public int? BetA { get; set; }
        public int? DepositeB { get; set; }
        public int? BetB { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
