using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UpgradeLog
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Loginname { get; set; }
        public decimal EffectMoney { get; set; }
        public string SourceLevel { get; set; }
        public string NewLevel { get; set; }
        public decimal? RebateRate { get; set; }
        public string GiveStatus { get; set; }
        public DateTime InsertDate { get; set; }
        public string Inserter { get; set; }
    }
}
