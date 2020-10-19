using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.Entity.Model
{
    public class ViewException : Exception
    {
        public ViewException(string mess)
            : base(mess)
        {

        }
    }
}
