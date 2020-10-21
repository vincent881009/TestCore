using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class PayCodeTypeSetting
    {
        public Guid Id { get; set; }
        public Guid PayTypeSettingId { get; set; }
        public Guid PaySettingId { get; set; }
        public string DisplayName { get; set; }
        public int PayTypeKind { get; set; }
        public string Status { get; set; }
        public string Exption1 { get; set; }
        public string Exption2 { get; set; }
        public string Exption3 { get; set; }
    }
}
