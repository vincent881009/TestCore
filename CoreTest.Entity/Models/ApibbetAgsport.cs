using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class ApibbetAgsport
    {
        public Guid Id { get; set; }
        public string Billno { get; set; }
        public string Playername { get; set; }
        public string Provider { get; set; }
        public decimal? Betamount { get; set; }
        public decimal? Validbetamount { get; set; }
        public decimal? Netamount { get; set; }
        public DateTime? Bettime { get; set; }
        public DateTime? Rtime { get; set; }
        public string Gametype { get; set; }
        public string Flag { get; set; }
        public string Playtype { get; set; }
        public string Loginip { get; set; }
        public DateTime? Racalcutime { get; set; }
        public string Platformtype { get; set; }
        public string Currency { get; set; }
        public string Odds { get; set; }
        public string Competition { get; set; }
        public string Market { get; set; }
        public string Selection { get; set; }
        public string Simplifiedresult { get; set; }
        public string Sport { get; set; }
        public string Category { get; set; }
        public string Live { get; set; }
        public string Currentscore { get; set; }
        public string Ext1 { get; set; }
        public string Ext2 { get; set; }
        public DateTime? SyncTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
