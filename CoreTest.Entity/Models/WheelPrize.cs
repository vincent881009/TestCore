using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class WheelPrize
    {
        public int Id { get; set; }
        public string MinAngle { get; set; }
        public string MaxAngle { get; set; }
        public string PrizeName { get; set; }
        public decimal Probability { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? AddLimit { get; set; }
    }
}
