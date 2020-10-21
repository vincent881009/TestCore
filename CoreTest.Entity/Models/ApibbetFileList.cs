using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class ApibbetFileList
    {
        public string FileName { get; set; }
        public long? FileSize { get; set; }
        public DateTime? LastModifyDate { get; set; }
    }
}
