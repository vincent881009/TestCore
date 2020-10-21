using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class SiteLog
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
