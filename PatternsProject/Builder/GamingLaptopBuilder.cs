using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class GamingLaptopBuilder : AbstractLaptopBuilder
    {
        public override void SetResolution()
        {
            Laptop.Resolution = "1920*1080";
        }

        public override void SetHDD()
        {
            Laptop.HDD = 2000;
        }

        public override void SetRAM()
        {
            Laptop.RAM = 8096;
        }

        public override void SetDVD()
        {
            Laptop.DVD = true;
        }

        public override void SetVideocard()
        {
            Laptop.VideoCard = 2048;
        }

        public override void SetProcessor()
        {
            Laptop.Processor = 3.7;
        }
    }
}
