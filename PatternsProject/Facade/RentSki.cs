using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class RentSki
    {
        public int RentBoots(int feetSize, int skierLevel)
        {
            return 20;
        }

        public int RentSkies(int skierHeight, int skierWieght)
        {
            return 40;
        }

        public int RentCloses(int skierSize)
        {
            return 60;
        }
    }
}
