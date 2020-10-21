using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class SysLog
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string LoginName { get; set; }
    }
}
