using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class AppSetting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int? Sort { get; set; }
        public string Name2 { get; set; }
        public string Atype { get; set; }
    }
}
