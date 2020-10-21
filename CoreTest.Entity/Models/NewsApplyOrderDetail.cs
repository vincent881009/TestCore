using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class NewsApplyOrderDetail
    {
        public Guid Id { get; set; }
        public Guid NewsApplyOrderId { get; set; }
        public Guid? NewsApplyId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Reamrk { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
