using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class GqchangeLog
    {
        public Guid Id { get; set; }
        public int? Gid { get; set; }
        public int? Type { get; set; }
        public string ChangeName { get; set; }
        public string Value { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
