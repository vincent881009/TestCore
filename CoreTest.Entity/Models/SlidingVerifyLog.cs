using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class SlidingVerifyLog
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Point { get; set; }
        public int? Length { get; set; }
        public string Mv { get; set; }
        public string Ma { get; set; }
        public int? Totaldate { get; set; }
        public string Sdata { get; set; }
        public string Sdatamd5 { get; set; }
    }
}
