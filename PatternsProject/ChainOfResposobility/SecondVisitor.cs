using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ChainOfResposobility
{
    internal class SecondVisitor : AbstractCafeVisitor
    {
        public SecondVisitor(AbstractCafeVisitor cafeVisitor)
            : base(cafeVisitor)
        {
        }

        public override void HandleFood(Food food)
        {
            if (food.Name == "Fish" || food.Name == "Meat")
            {
                Console.WriteLine("S MMM nice {0}", food.Name);
                return;
            }
            base.HandleFood(food);
        }
    }
}
