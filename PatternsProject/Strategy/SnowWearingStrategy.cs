using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class SnowWearingStrategy: IWearingStratery
    {
        public string weather { get; set; }

        public SnowWearingStrategy()
        {
            weather = "snow";
        }

        public string GetClothes()
        {
            return "Sweater";
        }

        public string GetAccessories()
        {
            return "snowboard";
        }
    }
}
