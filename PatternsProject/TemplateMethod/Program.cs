using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass tMA= new ConcerateA();

            tMA.Start();

            tMA = new ConcerateB();
            tMA.Start();
        }
    }
}
