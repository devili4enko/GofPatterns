using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ChainOfResposobility
{
    internal class FirstCafeVisitor : AbstractCafeVisitor
    {
        private int CupsOfCoffee;
        public FirstCafeVisitor(AbstractCafeVisitor cafeVisitor) : base(cafeVisitor)
        {
            CupsOfCoffee = 0;
        }

        public override void HandleFood(Food food)
        {
            if (food.Name == "Coffee" && CupsOfCoffee < 3)
            {
                Console.WriteLine("F MMMM nice Coffe");
                CupsOfCoffee++;
                return;
            }
            if (food.Name == "Meat")
            {
                Console.WriteLine("F MMMM nice stake");
                return;
            }
            
            base.HandleFood(food);
        }
    }
}
