using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserSignLog
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Loginname { get; set; }
        public Guid SignDayId { get; set; }
        public int SignDay { get; set; }
        public DateTime SignDate { get; set; }
        public decimal EffectiveMoney { get; set; }
        public DateTime InsertDate { get; set; }
        public string Inserter { get; set; }
    }
}
