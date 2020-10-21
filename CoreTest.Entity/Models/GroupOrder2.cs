using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class GroupOrder2
    {
        public Guid? Group { get; set; }
        public string LogionName { get; set; }
        public string Code { get; set; }
        public int? Count { get; set; }
        public int? Yijiesuan { get; set; }
        public decimal? AccessBeforeAmount { get; set; }
        public decimal? AccessAfterAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ResultAmount { get; set; }
        public decimal? TheoryAmount { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string Status { get; set; }
    }
}
