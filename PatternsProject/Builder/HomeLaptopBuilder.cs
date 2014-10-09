using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Builder
{
     class HomeLaptopBuilder : AbstractLaptopBuilder
    {
        public override void SetResolution()
        {
            Laptop.Resolution = "1368*763";
        }

        public override void SetHDD()
        {
            Laptop.HDD = 500;
        }

        public override void SetRAM()
        {
            Laptop.RAM = 2048;
        }

        public override void SetDVD()
        {
            Laptop.DVD = true;
        }

        public override void SetVideocard()
        {
            Laptop.VideoCard = 512;
        }

        public override void SetProcessor()
        {
            Laptop.Processor = 2.7;
        }
    }
}
