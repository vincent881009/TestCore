using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserExtensions
    {
        public Guid UserId { get; set; }
        public string Loginname { get; set; }
        public string LoginUrl { get; set; }
        public decimal? QuantityAmount { get; set; }
        public string TokenId { get; set; }
        public DateTime? PassTime { get; set; }
        public string InfoSource { get; set; }
    }
}
