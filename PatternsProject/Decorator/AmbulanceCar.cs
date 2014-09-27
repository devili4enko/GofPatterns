using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class AmbulanceCar : DecoratorCar
    {
        public AmbulanceCar(Car decoratedCar) : base(decoratedCar)
        {
        }

        public override void Go()
        {
            base.Go();
            Console.WriteLine("..qwe...");
        }
    }
}
