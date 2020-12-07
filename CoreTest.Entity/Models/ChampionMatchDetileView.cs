using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class ChampionMatchDetileView
    {
        public Guid Id { get; set; }
        public Guid? ChampionId { get; set; }
        public string TeamName { get; set; }
        public double? Ratio { get; set; }
        public bool? IsChampion { get; set; }
        public string Mid { get; set; }
        public bool? IsEnable { get; set; }
        public Guid Pid { get; set; }
        public int Code { get; set; }
        public string CompetitionName { get; set; }
        public string ProjectName { get; set; }
        public string WebCode { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public string Type { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? Gid { get; set; }
    }
}
