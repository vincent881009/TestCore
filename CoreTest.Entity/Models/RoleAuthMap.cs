using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class RoleAuthMap
    {
        public Guid Id { get; set; }
        public Guid? RoleId { get; set; }
        public string Auth { get; set; }
    }
}
