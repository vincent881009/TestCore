using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RoleManage
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public string MenuAuthList { get; set; }
        public string FunAuthList { get; set; }
        public string Exption1 { get; set; }
        public string Exption2 { get; set; }
        public string Exption3 { get; set; }
    }
}
