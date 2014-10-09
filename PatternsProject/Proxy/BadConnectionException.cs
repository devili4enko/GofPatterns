using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class BadConnectionException : Exception
    {
        public BadConnectionException(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
