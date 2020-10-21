using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserUpdateLog
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public string Type { get; set; }
        public string ColumnName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string SysUserName { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
