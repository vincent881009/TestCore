using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class VipSignMoney
    {
        public Guid Id { get; set; }
        public int DayNum { get; set; }
        public int Effective { get; set; }
        public decimal RebateRate { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Updater { get; set; }
        public string Inserter { get; set; }
    }
}
