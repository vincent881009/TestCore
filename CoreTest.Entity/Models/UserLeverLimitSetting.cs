using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class UserLeverLimitSetting
    {
        public string LeverName { get; set; }
        public decimal SportLimit { get; set; }
        public decimal SportMax { get; set; }
        public decimal CaipiaoLimit { get; set; }
        public decimal CaipiaoMax { get; set; }
        public string Execties1 { get; set; }
        public string Execties2 { get; set; }
        public string Execties3 { get; set; }
        public decimal? AomenliuheLimit { get; set; }
        public decimal? AomenliuheMax { get; set; }
        public decimal? AomenshifenliuheLimit { get; set; }
        public decimal? AomenshifenliuheMax { get; set; }
        public decimal? TyzqdyMin { get; set; }
        public decimal? TyzqdyMax { get; set; }
        public decimal? TyzqbdMin { get; set; }
        public decimal? TyzqbdMax { get; set; }
        public decimal? TygqMin { get; set; }
        public decimal? TygqMax { get; set; }
    }
}
