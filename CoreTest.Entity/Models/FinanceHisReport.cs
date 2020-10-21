using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class FinanceHisReport
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public DateTime? CreateData { get; set; }
        public string Type { get; set; }
        public decimal? Zongtouzhu { get; set; }
        public decimal? Youxiao { get; set; }
        public decimal? Resout { get; set; }
    }
}
