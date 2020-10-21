using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class CspsettlementLog
    {
        public Guid Id { get; set; }
        public string Mid { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string UpdateBy { get; set; }
        public string Stauts { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
