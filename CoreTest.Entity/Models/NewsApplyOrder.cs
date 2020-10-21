using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class NewsApplyOrder
    {
        public Guid Id { get; set; }
        public Guid NewsId { get; set; }
        public string LoginName { get; set; }
        public int? Status { get; set; }
        public string Ip { get; set; }
        public DateTime? ApplyTime { get; set; }
        public string Reamrk { get; set; }
        public DateTime CreateTime { get; set; }
        public string ApplyNo { get; set; }
    }
}
