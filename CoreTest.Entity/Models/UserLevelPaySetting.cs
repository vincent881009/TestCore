using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserLevelPaySetting
    {
        public int Id { get; set; }
        public string UserLevelName { get; set; }
        public string PaySettingId { get; set; }
    }
}
