using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class OnlinePlay
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public string Code { get; set; }
        public decimal? Amount { get; set; }
        public string PlayType { get; set; }
        public string Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? SuccessTime { get; set; }
        public string Remark { get; set; }
        public string Operator { get; set; }
        public string ThirdPlatformNo { get; set; }
        public string Remark1 { get; set; }
        public string ThirdLog { get; set; }
    }
}
