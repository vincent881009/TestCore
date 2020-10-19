using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.Entity
{
    public  class SysUser
    {
        public System.Guid id { get; set; }
        public string name { get; set; }
        public string loginName { get; set; }
        public string pwd { get; set; }
        public string iPplace { get; set; }
        public string addrPlace { get; set; }
        public Nullable<bool> loginPlace { get; set; }
        public string auth { get; set; }
        public string stauts { get; set; }
        public string menuAuthList { get; set; }
        public string funAuthList { get; set; }
        public string googleSecretKey { get; set; }
        public Nullable<bool> enableGoogleAuth { get; set; }
    }
}
