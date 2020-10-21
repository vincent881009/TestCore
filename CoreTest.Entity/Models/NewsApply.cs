using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class NewsApply
    {
        public Guid Id { get; set; }
        public Guid NewsId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public bool Require { get; set; }
        public string Type { get; set; }
        public int? Sort { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
