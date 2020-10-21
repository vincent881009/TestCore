using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserMonthReportByAgent
    {
        public string LoginName { get; set; }
        public string ReportMonth { get; set; }
        public string UserGroup { get; set; }
        public decimal? SpShuYingMoney { get; set; }
        public decimal? SpWeiJieSuanMoney { get; set; }
        public decimal? SpYouXiaoMoney { get; set; }
        public decimal? SpXiaZhuMoney { get; set; }
        public decimal? NspShuYingMoney { get; set; }
        public decimal? NspWeiJieSuanMoney { get; set; }
        public decimal? NspYouXiaoMoney { get; set; }
        public decimal? NspXiaZhuMoney { get; set; }
        public decimal? CpShuYingMoney { get; set; }
        public decimal? CpWeiJieSuanMoney { get; set; }
        public decimal? CpXiaZhuMoney { get; set; }
        public decimal? LhShuYingMoney { get; set; }
        public decimal? LhWeiJieSuanMoney { get; set; }
        public decimal? LhXiaZhuMoney { get; set; }
        public decimal? ZrTransferInMoney { get; set; }
        public decimal? ZrTransferOutMoney { get; set; }
        public decimal? ZrBetamount { get; set; }
        public decimal? ZrValidamount { get; set; }
        public decimal? ZrNetamount { get; set; }
        public decimal? Chongzhi { get; set; }
        public decimal? Tixian { get; set; }
    }
}
