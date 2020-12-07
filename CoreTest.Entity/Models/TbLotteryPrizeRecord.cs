using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class TbLotteryPrizeRecord
    {
        public int Id { get; set; }
        public string LotteryName { get; set; }
        public string BatchNo { get; set; }
        public TimeSpan? PrizeTime { get; set; }
    }
}
