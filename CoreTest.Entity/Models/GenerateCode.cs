using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class GenerateCode
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? Index { get; set; }
        public DateTime DateTime { get; set; }
    }
}
