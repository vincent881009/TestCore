using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UsersRolesMap
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string RoleName { get; set; }
    }
}
