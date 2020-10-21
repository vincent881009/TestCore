using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class News
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Banner { get; set; }
        public string Body { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Status { get; set; }
        public int? Sortkey { get; set; }
        public string Sitekey { get; set; }
        public Guid? NewsTypeId { get; set; }
        public string NewsTypeName { get; set; }
        public string Banner2 { get; set; }
    }
}
