using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserSetting
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int IsFarbudLogin { get; set; }
        public int IsFarbudTouZhu { get; set; }
        public int IsFarbudCunKuan { get; set; }
        public int IsFarbudQuKuan { get; set; }
        public int IsFarbudEdzh { get; set; }
        public int IsFarbudFb { get; set; }
        public int IsFarbudBb { get; set; }
        public int IsFarbudTb { get; set; }
        public int IsFarbudVb { get; set; }
        public int IsFarbudBd { get; set; }
        public int IsFarbudPp { get; set; }
        public int IsFarbudBaseBall { get; set; }
        public int IsFarbudOther { get; set; }
        public string Edzhdetail { get; set; }
        public int IsNewsApply { get; set; }
        public int IsFarbudFbdj { get; set; }
        public int IsFarbudBbdj { get; set; }
        public int IsFarbudBank { get; set; }
    }
}
