using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.Data.Model
{
    public class ViewException : Exception
    {
        public ViewException(string mess)
            : base(mess)
        {

        }
    }
}
