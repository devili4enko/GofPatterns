using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    abstract class Car
    {
        protected string BrandName;

        public virtual void Go()
        {
            Console.WriteLine("I'm {0} and i'm on my way", BrandName);
        }
    }
}
