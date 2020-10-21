using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class AppSettingLog
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public string AppValue { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
