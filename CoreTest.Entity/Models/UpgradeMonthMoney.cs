using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UpgradeMonthMoney
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Loginname { get; set; }
        public string VipLevel { get; set; }
        public decimal RebateRate { get; set; }
        public string GiveStatus { get; set; }
        public DateTime UpgradeTime { get; set; }
        public DateTime InsertDate { get; set; }
        public string Inserter { get; set; }
    }
}
