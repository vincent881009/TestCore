using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RedEnvelopeConfigMoney
    {
        public Guid Id { get; set; }
        public string CanRedEnvelopeLevel { get; set; }
        public int? Status { get; set; }
        public string MaxMoney { get; set; }
        public string MinMoney { get; set; }
    }
}
