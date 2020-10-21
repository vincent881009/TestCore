using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RedEnvelopeLevelSetting
    {
        public Guid Id { get; set; }
        public string LevelName { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
