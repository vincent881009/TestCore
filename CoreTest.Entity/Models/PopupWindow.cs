using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class PopupWindow
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public bool Enable { get; set; }
    }
}
