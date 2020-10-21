using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class Bak20190701VideoGameTransferLog
    {
        public Guid Id { get; set; }
        public string Kind { get; set; }
        public string LoginName { get; set; }
        public string GameAccount { get; set; }
        public string GamePwd { get; set; }
        public decimal? AdjMoney { get; set; }
        public string ClientIp { get; set; }
        public string Device { get; set; }
        public string Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Remark { get; set; }
        public string BillNo { get; set; }
    }
}
