using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class ApibbetSync
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; }
        public string SyncApi { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
    }
}
