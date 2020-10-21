using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class Iplog
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Ip { get; set; }
        public string SiteName { get; set; }
        public string Url { get; set; }
    }
}
