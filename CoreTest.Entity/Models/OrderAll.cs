using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class OrderAll
    {
        public string LoginName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public decimal? Amount { get; set; }
        public decimal? TuishuiAmount { get; set; }
        public decimal? ValidAmount { get; set; }
    }
}
