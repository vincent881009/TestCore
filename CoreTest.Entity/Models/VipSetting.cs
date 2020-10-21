using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class VipSetting
    {
        public string Name { get; set; }
        public decimal UpgradeMoney { get; set; }
        public decimal UpgradeForMoney { get; set; }
        public decimal EveryMonthMoney { get; set; }
        public int Sort { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Updater { get; set; }
        public string Inserter { get; set; }
        public decimal? MonthMoneyStandard { get; set; }
        public int? MonthMoneyCount { get; set; }
        public string Exp1 { get; set; }
        public string Exp2 { get; set; }
        public string Exp3 { get; set; }
    }
}
