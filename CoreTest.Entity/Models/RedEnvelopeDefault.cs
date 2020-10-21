using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RedEnvelopeDefault
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public string RedEnvelopePrize { get; set; }
        public int? Status { get; set; }
        public DateTime? Createtime { get; set; }
    }
}
