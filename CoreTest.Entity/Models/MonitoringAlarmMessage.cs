using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class MonitoringAlarmMessage
    {
        public Guid Id { get; set; }
        public string AlarmName { get; set; }
        public string AlarmDescription { get; set; }
        public string AlarmLevel { get; set; }
        public string HostName { get; set; }
        public string HostGroup { get; set; }
        public Guid? HostId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ToUser { get; set; }
        public DateTime? SendTime { get; set; }
        public string Status { get; set; }
    }
}
