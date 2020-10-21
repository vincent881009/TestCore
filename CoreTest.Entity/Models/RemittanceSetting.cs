using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RemittanceSetting
    {
        public Guid Id { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string OpenName { get; set; }
        public string BankAddr { get; set; }
        public string UserGroup { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
