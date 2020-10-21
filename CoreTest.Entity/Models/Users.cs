using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class Users
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public string Pwd { get; set; }
        public string Status { get; set; }
    }
}
