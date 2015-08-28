using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcerateB : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("ConcerateB Operation1");
        }

        public override void Operation2()
        {
            Console.WriteLine("ConcerateB Operation2");
        }
    }
}
