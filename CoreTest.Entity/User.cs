using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Entity
{
    public class User
    {
        public System.Guid id { get; set; }
        public string loginname { get; set; }
        public string pwd { get; set; }
        public string username { get; set; }
        public Nullable<System.DateTime> registData { get; set; }
        public Nullable<decimal> balance { get; set; }
        public string registIP { get; set; }
        public string lastLoginIP { get; set; }
        public string agent { get; set; }
        public string phone { get; set; }
        public string mailaddr { get; set; }
        public string userGroup { get; set; }
        public string status { get; set; }
        public string sex { get; set; }
        public string registaddr { get; set; }
        public string pwdAnswer { get; set; }
        public string pwdQuestion { get; set; }
        public string qq { get; set; }
        public string openBank { get; set; }
        public string bankCrad { get; set; }
        public string openBandAddr { get; set; }
        public Nullable<System.DateTime> lastLoginData { get; set; }
        public Nullable<System.DateTime> lastLogoutData { get; set; }
        public Nullable<int> loginCount { get; set; }
        public string remark { get; set; }
        public string isdelete { get; set; }
        public string CradPwd { get; set; }
        public string userLeve { get; set; }
        public string iPplace { get; set; }
        public string playset { get; set; }
        public string GamePwd { get; set; }
        public string game_account { get; set; }
        public Nullable<bool> IsTuishui { get; set; }
        public Nullable<bool> isreportignore { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string OpenBankSub { get; set; }
        public string weixin { get; set; }
        public Nullable<bool> Eliminated { get; set; }
        public string VipLevel { get; set; }
        public Nullable<int> depositCount { get; set; }
        public Nullable<int> withdrawCount { get; set; }
        public Nullable<decimal> depositSum { get; set; }
        public Nullable<System.DateTime> firstDepositTime { get; set; }
        public Nullable<decimal> firstDepositNum { get; set; }
        public Nullable<System.DateTime> maxDepositTime { get; set; }
        public Nullable<decimal> maxDepositNum { get; set; }
        public Nullable<decimal> withdrawSum { get; set; }
        public Nullable<System.DateTime> firstWithdrawTime { get; set; }
        public Nullable<decimal> firstWithdrawNum { get; set; }
        public Nullable<System.DateTime> maxWithdrawTime { get; set; }
        public Nullable<decimal> maxWithdrawNum { get; set; }


    }
}
