using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class DepositClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Sort { get; set; }
        public bool? Isshow { get; set; }
        public string Frontdesc { get; set; }
        public string Hgdesc { get; set; }
        public string Phonedesc { get; set; }
        public string Linkurl { get; set; }
        public string Frontcolor { get; set; }
        public string Frontbackgroundcolor { get; set; }
        public string Frontfontsize { get; set; }
        public string Hgcolor { get; set; }
        public string Hgbackgroundcolor { get; set; }
        public string Hgfontsize { get; set; }
        public string Phonecolor { get; set; }
        public string Phonebackgroundcolor { get; set; }
        public string Phonefontsize { get; set; }
    }
}
