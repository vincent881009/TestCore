using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.Service.Model.Layui
{
   public  class LayuiParam
    {
        public int page { get; set; } = 1;
        public int limit { get; set; } = 100;
        public string field { get; set; }
        public string order { get; set; }

    }
}
