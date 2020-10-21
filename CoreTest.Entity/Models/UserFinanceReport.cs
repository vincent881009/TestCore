using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserFinanceReport
    {
        public Guid Id { get; set; }
        public string LoginName { get; set; }
        public DateTime? ReportDay { get; set; }
        public DateTime? RegistTime { get; set; }
        public decimal? Chongzhi { get; set; }
        public decimal? Tixian { get; set; }
        public int? Touzhuliang { get; set; }
        public decimal? Touzhujine { get; set; }
        public decimal? Jiesuanjine { get; set; }
        public decimal? Yinli { get; set; }
        public decimal? Yue { get; set; }
    }
}
