using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class RentRoom
    {
        public int Rent(int roomQuality)
        {
            switch (roomQuality)
            {
                case 3:
                    return 200;
                case 4:
                    return 300;
                case 5:
                    return 400;
                default:
                    throw new ArgumentException("Please choose from 3 to 5");
            }
        }
    }
}
