using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class OrderBakTo20150101
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public int? MatchId { get; set; }
        public string MatchName { get; set; }
        public string MatchType { get; set; }
        public string Type { get; set; }
        public string HostsTing { get; set; }
        public decimal? Odds { get; set; }
        public string Score { get; set; }
        public string PlayType { get; set; }
        public string OrderContent { get; set; }
        public string GroupCode { get; set; }
        public decimal? AccessBeforeAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AccessAfterAmount { get; set; }
        public decimal? ResultAmount { get; set; }
        public decimal? TheoryAmount { get; set; }
        public DateTime? SubmitTime { get; set; }
        public DateTime? BeginTime { get; set; }
        public string LogionName { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string ContextExt { get; set; }
        public string ScorePan { get; set; }
        public string ScoreJu { get; set; }
        public decimal? TuishuiAmount { get; set; }
        public DateTime? Islock { get; set; }
        public string CreteSource { get; set; }
        public string SettlementHpoint { get; set; }
        public string SettlementTpoint { get; set; }
        public DateTime? MatchTime { get; set; }
        public bool? IsToSettlement { get; set; }
        public DateTime? SubmitTimeapprove { get; set; }
        public string Freeze { get; set; }
    }
}
