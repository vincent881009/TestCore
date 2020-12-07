using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class HgNotice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Type { get; set; }
        public string UserName { get; set; }
        public bool? IsRead { get; set; }
        public string MessType { get; set; }
    }
}
