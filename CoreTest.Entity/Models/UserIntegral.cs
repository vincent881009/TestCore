using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserIntegral
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Integral { get; set; }
        public string Exption1 { get; set; }
        public string Exption2 { get; set; }
        public string Exption3 { get; set; }
    }
}
