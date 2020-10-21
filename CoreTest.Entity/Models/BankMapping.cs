using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class BankMapping
    {
        public Guid Id { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankNameSub { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
    }
}
