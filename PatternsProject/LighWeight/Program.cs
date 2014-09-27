using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LighWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            //var army = new Army<Dragon, Goblin>();
            var army = new Army<LightweightDragon, LightweightGoblin>();
            army.SetArmy();

            Console.ReadLine();
        }
    }
}
