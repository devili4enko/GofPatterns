using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class TripLaptopBuilder : AbstractLaptopBuilder 
    {
        public override void SetResolution()
        {
            Laptop.Resolution = "1368*763";
        }

        public override void SetHDD()
        {
            Laptop.HDD = 250;
        }

        public override void SetRAM()
        {
            Laptop.RAM = 1024;
        }

        public override void SetDVD()
        {
            Laptop.DVD = false;
        }

        public override void SetVideocard()
        {
            Laptop.VideoCard = 256;
        }

        public override void SetProcessor()
        {
            Laptop.Processor = 2.0;
        }
    }
}
