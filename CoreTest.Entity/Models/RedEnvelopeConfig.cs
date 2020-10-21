using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RedEnvelopeConfig
    {
        public Guid Id { get; set; }
        public string RedEnvelopeNo { get; set; }
        public string Name { get; set; }
        public string Probability { get; set; }
        public int? Number { get; set; }
        public string RedEnvelopeType { get; set; }
        public string Creator { get; set; }
        public string Price { get; set; }
        public int? IsEnable { get; set; }
    }
}
