using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResposobility
{
    internal class ThirdVisitor : AbstractCafeVisitor
    {
        public ThirdVisitor(AbstractCafeVisitor cafeVisitor)
            : base(cafeVisitor)
        {
        }

        public override void HandleFood(Food food)
        {
            if (food.Name == "Coffee")// && food.Ingradients.Count < 4)
            {
                Console.WriteLine("AAAAAAAAAAAAa alast");
            }
            //base.HandleFood(food);
        }
    }
}
