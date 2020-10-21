using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class PwdChanged
    {
        public string LoginName { get; set; }
        public DateTime LastTime { get; set; }
        public string History { get; set; }
    }
}
