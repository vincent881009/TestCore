using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class Suggest
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string Content { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public string Status { get; set; }
    }
}
