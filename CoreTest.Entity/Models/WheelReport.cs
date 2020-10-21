using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class WheelReport
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
