using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class ChampionItem
    {
        public Guid Id { get; set; }
        public Guid? ChampionId { get; set; }
        public string TeamName { get; set; }
        public double? Ratio { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsChampion { get; set; }
        public string Mid { get; set; }
        public bool? IsEnable { get; set; }
    }
}
