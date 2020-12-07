using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbMatchMaster
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public string Status { get; set; }
        public int? Gid { get; set; }
        public DateTime? Datetime { get; set; }
        public string League { get; set; }
        public int? GunmH { get; set; }
        public int? GunmC { get; set; }
        public string TeamH { get; set; }
        public string TeamC { get; set; }
        public string Strong { get; set; }
        public int? More { get; set; }
        public string Eventid { get; set; }
        public string Hot { get; set; }
        public string CenterTv { get; set; }
        public string Play { get; set; }
        public int? ScoreH { get; set; }
        public int? ScoreC { get; set; }
        public int? Time { get; set; }
        public int? FScoreH { get; set; }
        public int? FScoreC { get; set; }
        public string FStatus { get; set; }
        public int? ChargeStatus { get; set; }
        public int? Kind { get; set; }
        public int? HScoreH { get; set; }
        public int? HScoreC { get; set; }
        public int? FPointH { get; set; }
        public int? FPointC { get; set; }
        public int? HPointH { get; set; }
        public int? HPointC { get; set; }
        public bool? IsEnable { get; set; }
        public int? Gidm { get; set; }
        public bool? IsShowGq { get; set; }
        public bool? IsEnable2 { get; set; }
        public bool? ShowScoreH { get; set; }
        public bool? ShowScoreC { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int? HSettlement { get; set; }
        public int? CSettlement { get; set; }
        public int? IshowWeb { get; set; }
        public int? IsColse { get; set; }
        public string IsCancel { get; set; }
    }
}
