using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class Hongbao
    {
        public Guid Gid { get; set; }
        public string Id { get; set; }
        public string IsReal { get; set; }
        public string NickName { get; set; }
        public string PhoneNumber { get; set; }
        public string Account { get; set; }
        public string AccountType { get; set; }
        public string CreateTime { get; set; }
        public string Money { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public string UpdateTime { get; set; }
        public string UserId { get; set; }
        public string ApprovedStatus { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
