using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class MenuInit
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public int IsShow { get; set; }
        public string Exption1 { get; set; }
        public string Exption2 { get; set; }
        public string Exption3 { get; set; }
    }
}
