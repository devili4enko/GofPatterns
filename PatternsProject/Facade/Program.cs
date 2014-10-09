using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var skiComplex = new SkiResortFacade();
            
            Console.WriteLine(skiComplex.OneDayWithoutSkies());

            Console.WriteLine(skiComplex.WeekEndDealWithoutSkies(4));

            Console.WriteLine(skiComplex.FullComplex(42,5,182,88,42,5,4));
        }
    }
}
