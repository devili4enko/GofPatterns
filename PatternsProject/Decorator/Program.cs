using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mers = new Mercedes();

            mers.Go();

            var ambulance = new AmbulanceCar(mers);

            ambulance.Go();

        }
    }
}
