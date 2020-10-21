using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class SiteInfo1
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }
        public string SiteDesc { get; set; }
        public string IndexGonggao { get; set; }
        public bool? IsYouhuiHuodong { get; set; }
    }
}
