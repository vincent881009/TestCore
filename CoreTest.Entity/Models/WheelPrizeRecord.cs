using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class WheelPrizeRecord
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string PrizeName { get; set; }
        public string UserIp { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Modifier { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
