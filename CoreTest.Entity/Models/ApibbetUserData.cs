using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class ApibbetUserData
    {
        public Guid Id { get; set; }
        public string BillNo { get; set; }
        public string FileName { get; set; }
        public string Agent { get; set; }
        public string Member { get; set; }
        public string MemberName { get; set; }
        public string UserName { get; set; }
        public decimal? BetAmount { get; set; }
        public decimal? ValidAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public long? TimeStamp { get; set; }
        public DateTime? Time { get; set; }
        public DateTime? TimeChn { get; set; }
        public DateTime? TimeUst { get; set; }
        public DateTime? TimeUtc { get; set; }
        public string Type { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastModifyTime { get; set; }
    }
}
