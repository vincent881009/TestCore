using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class FarbudItems
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string LoginName { get; set; }
        public string Ttype { get; set; }
        public string Kind { get; set; }
        public string Cata { get; set; }
        public DateTime CreateTime { get; set; }
        public string Creator { get; set; }
        public string Exp1 { get; set; }
        public string Exp2 { get; set; }
        public string Exp3 { get; set; }
    }
}
