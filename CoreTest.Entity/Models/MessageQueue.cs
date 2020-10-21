using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class MessageQueue
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? ObjectId { get; set; }
        public string Content { get; set; }
        public string LoginName { get; set; }
    }
}
