using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class OrderCsp
    {
        public Guid Id { get; set; }
        public string BoiId { get; set; }
        public string BetOrderId { get; set; }
        public decimal? Ceiling { get; set; }
        public decimal? RealCeiling { get; set; }
        public decimal? RealWinCeiling { get; set; }
        public string MatchRate { get; set; }
        public string Type { get; set; }
        public string OrderNo { get; set; }
        public string Account { get; set; }
        public string GameType { get; set; }
        public string SubGameType { get; set; }
        public string MatchInfo { get; set; }
        public DateTime? BetTime { get; set; }
        public string MatchDate { get; set; }
        public string Status { get; set; }
        public string HomeInBall { get; set; }
        public string AwayInBall { get; set; }
        public string HomeInBallHalf { get; set; }
        public string AwayInBallHalf { get; set; }
        public string BetOrderStatus { get; set; }
        public decimal? TuishuiCeiling { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Check { get; set; }
        public int? Fstatus { get; set; }
        public DateTime? SyncTime { get; set; }
    }
}
