using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class VipinputEffectMoneyTotalHistory
    {
        public string Loginname { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public decimal TotalMoney { get; set; }
        public string Exption1 { get; set; }
        public string Exption2 { get; set; }
    }
}
