using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var _shop = new LaptopShop();
            _shop.GetBuilder(new GamingLaptopBuilder());
            _shop.MakeLaptop();
            var _laptop = _shop.GetLaptop();
            Console.WriteLine(_laptop);

            _shop.GetBuilder(new TripLaptopBuilder());
            _shop.MakeLaptop();
            var secondLaptop = _shop.GetLaptop();
            Console.WriteLine(secondLaptop);

        }
    }
}
