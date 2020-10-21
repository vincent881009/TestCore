using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RedEnvelopePrize
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? RedEnvelopeCount { get; set; }
    }
}
