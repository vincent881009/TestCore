using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class WheelRules
    {
        public int Id { get; set; }
        public decimal MoneyLimit { get; set; }
        public int CountLimit { get; set; }
        public int DayLimit { get; set; }
        public string PayType { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Expression { get; set; }
    }
}
