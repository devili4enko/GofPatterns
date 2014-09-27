using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class Cat
    {
        public void Talk()
        {
            Say();
        }

        protected virtual void Say()
        {
            Console.WriteLine("I'm standart Cat");
        }
    }
}
