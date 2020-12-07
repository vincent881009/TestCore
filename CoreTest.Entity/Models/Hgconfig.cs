using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class Hgconfig
    {
        public int Id { get; set; }
        public string Hgaccount { get; set; }
        public string Hgpwd { get; set; }
        public string Hgmid { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
