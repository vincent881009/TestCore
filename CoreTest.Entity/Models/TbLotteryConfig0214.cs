using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbLotteryConfig0214
    {
        public int Id { get; set; }
        public string LotteryName { get; set; }
        public string StartTime { get; set; }
        public int? PeriodTime { get; set; }
        public string EndTime { get; set; }
        public string Status { get; set; }
        public int? CloseTime { get; set; }
        public bool? EnablePrizeRecord { get; set; }
        public int? ClosePandingTime { get; set; }
        public bool PcEnable { get; set; }
        public bool HgEnable { get; set; }
        public bool PhoneEnable { get; set; }
        public int? Sort { get; set; }
    }
}
