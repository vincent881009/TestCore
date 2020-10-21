using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RedEnvelopeSetting
    {
        public int Id { get; set; }
        public string WheelName { get; set; }
        public string IpLimit { get; set; }
        public string MobileLimit { get; set; }
        public int? TotalLimit { get; set; }
        public bool IsEnabled { get; set; }
        public string Rules { get; set; }
        public string Statement { get; set; }
        public string Remark { get; set; }
        public string WheelImgUrl { get; set; }
        public bool IsOneMemberDoOne { get; set; }
        public string Activity { get; set; }
        public string Flow { get; set; }
        public int OneDayMemberDoNumber { get; set; }
        public bool IsOneDayClearLimit { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
