using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class PaySetting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Code2 { get; set; }
        public string Snk { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string Status { get; set; }
        public string Snk2 { get; set; }
        public string Snk3 { get; set; }
        public string PayType { get; set; }
        public string TypeName { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public decimal? Deduction { get; set; }
        public int? Sort { get; set; }
        public string BankAccountUserName { get; set; }
        public string DepositBank { get; set; }
        public string Remark { get; set; }
        public bool? PcShow { get; set; }
        public bool? PhoneShow { get; set; }
        public string SiteName { get; set; }
        public string DirectConnectParam { get; set; }
        public string PayInfo { get; set; }
        public decimal? FirstPresent { get; set; }
        public int? OnlinePayMin { get; set; }
        public int? OnlinePayMax { get; set; }
        public string GatewayUrl { get; set; }
        public DateTime? CreateTime { get; set; }
        public string FixedAmount { get; set; }
        public string CallbackIp { get; set; }
        public bool? RandomDecimalAmount { get; set; }
    }
}
