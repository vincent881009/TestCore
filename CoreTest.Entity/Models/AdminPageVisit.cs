using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class AdminPageVisit
    {
        public int Id { get; set; }
        public string PageUrl { get; set; }
        public long? PageCount { get; set; }
        public string SiteName { get; set; }
    }
}
