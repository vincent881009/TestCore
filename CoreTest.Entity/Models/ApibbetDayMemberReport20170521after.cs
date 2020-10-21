using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class ApibbetDayMemberReport20170521after
    {
        public int RakebackId { get; set; }
        public string AgentSite { get; set; }
        public string MemberId { get; set; }
        public string MemberAccount { get; set; }
        public string MemberName { get; set; }
        public decimal? Betamount { get; set; }
        public decimal? Validamount { get; set; }
        public decimal? Netamount { get; set; }
        public string GameType { get; set; }
        public string CalcDate { get; set; }
        public string Provider { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
