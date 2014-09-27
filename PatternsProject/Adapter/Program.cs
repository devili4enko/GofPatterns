using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var home = new NewElectrisitySystem();
            ElecticityConsumer.ChargeLaptop(home);

            var _work = new Adapter(new OldElectricitySystem());
            ElecticityConsumer.ChargeLaptop(_work);

        }
    }
}
