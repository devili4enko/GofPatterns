using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class DecoratorCar : Car
    {
        protected Car DecoratedCar { get; set; }

        public DecoratorCar(Car decoratedCar)
        {
            DecoratedCar = decoratedCar;
        }

        public override void Go()
        {
            DecoratedCar.Go();
        }
    }
}
