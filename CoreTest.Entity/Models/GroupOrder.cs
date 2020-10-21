using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class GroupOrder
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime? SubmitTime { get; set; }
        public string LoginName { get; set; }
        public string Status { get; set; }
        public int? Count { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ResultAmount { get; set; }
        public decimal? TheoryAmount { get; set; }
        public decimal? TuishuiAmount { get; set; }
        public decimal? Youxiao { get; set; }
    }
}
