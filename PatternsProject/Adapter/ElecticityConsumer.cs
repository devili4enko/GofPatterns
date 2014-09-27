using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class ElecticityConsumer
    {
        public static void ChargeLaptop(INewElectisitySystem electisitySystem)
        {
            Console.WriteLine(electisitySystem.MatchWideSocket());
        }
    }
}
