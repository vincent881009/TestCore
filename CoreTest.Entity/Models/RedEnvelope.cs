using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RedEnvelope
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public string RedEnvelopePrizeId { get; set; }
        public DateTime? Createtime { get; set; }
        public int? Status { get; set; }
    }
}
