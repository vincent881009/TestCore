using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class PayTypeSetting
    {
        public Guid Id { get; set; }
        public int KindId { get; set; }
        public string DisplayName { get; set; }
        public string Exption1 { get; set; }
        public string Exption2 { get; set; }
        public string Exption3 { get; set; }
    }
}
