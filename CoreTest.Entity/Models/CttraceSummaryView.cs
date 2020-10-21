using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class CttraceSummaryView
    {
        public short EventClass { get; set; }
        public long? TextDataHashCode { get; set; }
        public string NormalizedTextData { get; set; }
        public string SampleTextData { get; set; }
        public int? Cpu { get; set; }
        public long? Reads { get; set; }
        public long? Writes { get; set; }
        public long? Duration { get; set; }
        public int? ExecutionCount { get; set; }
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public int LoginId { get; set; }
        public string LoginName { get; set; }
        public int HostId { get; set; }
        public string HostName { get; set; }
        public int? ServerId { get; set; }
        public string ServerName { get; set; }
        public int TraceFileId { get; set; }
        public int TraceId { get; set; }
        public string TraceName { get; set; }
        public int DateId { get; set; }
        public DateTime? CalendarDate { get; set; }
        public int TimeId { get; set; }
    }
}
