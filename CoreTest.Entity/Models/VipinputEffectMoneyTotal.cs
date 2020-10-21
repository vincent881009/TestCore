using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class VipinputEffectMoneyTotal
    {
        public string Loginname { get; set; }
        public DateTime InsertDate { get; set; }
        public decimal TotalMoney { get; set; }
        public string SourceVip { get; set; }
    }
}
