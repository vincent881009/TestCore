using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserBalance
    {
        public Guid Id { get; set; }
        public string Loginname { get; set; }
        public decimal? Balance { get; set; }
    }
}
