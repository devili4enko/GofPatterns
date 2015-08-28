using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class AbstractClass
    {
        public abstract void Operation1();
        public abstract void Operation2();

        public void Start()
        {
            Operation1();
            Operation2();
        }
    }
}
