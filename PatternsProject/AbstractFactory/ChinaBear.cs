using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class ChinaBear : Bear
    {
        protected override void Say()
        {
            Console.WriteLine("I'm Chinese Bear");
        }
    }
}
