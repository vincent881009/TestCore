using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class MaintenancePlan
    {
        public int Id { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string PlanScope { get; set; }
        public string Contents { get; set; }
    }
}
