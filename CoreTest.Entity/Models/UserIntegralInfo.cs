using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserIntegralInfo
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public string FinanceType { get; set; }
        public DateTime CreateTime { get; set; }
        public decimal Amount { get; set; }
        public int Integral { get; set; }
        public decimal TopUpSum { get; set; }
        public decimal WarthDraw { get; set; }
        public string Exption1 { get; set; }
        public string Exption2 { get; set; }
        public string Exption3 { get; set; }
    }
}
