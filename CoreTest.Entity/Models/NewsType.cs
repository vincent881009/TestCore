using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class NewsType
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public string Exption1 { get; set; }
        public string Exption2 { get; set; }
        public int? Sort { get; set; }
        public Guid? ParentId { get; set; }
    }
}
