using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResposobility
{
    class Program
    {
        static void Main(string[] args)
        {
            var third = new ThirdVisitor(null);
            var second = new SecondVisitor(third);
            var first = new FirstCafeVisitor(second);

            var food = new List<Food>();

            food.Add(new Food(){Ingradients = new List<string>(), Name = "Coffee"});
            food.Add(new Food() { Ingradients = new List<string>(), Name = "Coffee" });
            food.Add(new Food() { Ingradients = new List<string>(), Name = "Coffee" });
            food.Add(new Food() { Ingradients = new List<string>(), Name = "Fish" });
            food.Add(new Food() { Ingradients = new List<string>(), Name = "Meat" });
            food.Add(new Food() { Ingradients = new List<string>(), Name = "Meat" });
            food.Add(new Food() { Ingradients = new List<string>(), Name = "Coffee" });

            foreach (var food1 in food)
            {
                first.HandleFood(food1);
            }
        }
    }
}
