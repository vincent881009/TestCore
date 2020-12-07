using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class BaseMatch
    {
        public Guid Id { get; set; }
        public string CompetitionName { get; set; }
        public string HostsTeam { get; set; }
        public string TingTeam { get; set; }
        public string WebCode { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public string Type { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
