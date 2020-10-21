using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class SysUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Pwd { get; set; }
        public string IPplace { get; set; }
        public string AddrPlace { get; set; }
        public bool? LoginPlace { get; set; }
        public string Auth { get; set; }
        public string Stauts { get; set; }
        public string MenuAuthList { get; set; }
        public string FunAuthList { get; set; }
        public string GoogleSecretKey { get; set; }
        public bool? EnableGoogleAuth { get; set; }
    }
}
