using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class PlayThreshold
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MaxValue { get; set; }
        public bool? ItemType { get; set; }
        public int? Sort { get; set; }
        public string LoginName { get; set; }
    }
}
