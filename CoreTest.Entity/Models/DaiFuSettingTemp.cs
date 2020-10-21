using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class DaiFuSettingTemp
    {
        public Guid Id { get; set; }
        public string DaiFuName { get; set; }
        public string DaiFuCode { get; set; }
        public string Code { get; set; }
        public string Snk { get; set; }
        public string BizKey { get; set; }
        public string AnsycHost { get; set; }
        public string DaiFuPro { get; set; }
        public string PayPwd { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Updater { get; set; }
        public string Creator { get; set; }
        public string Status { get; set; }
        public string Snk2 { get; set; }
        public string Snk3 { get; set; }
    }
}
