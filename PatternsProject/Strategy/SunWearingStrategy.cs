using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class SunWearingStrategy: IWearingStratery
    {
        public string weather { get; set; }

        public SunWearingStrategy()
        {
            weather = "sun";
        }

        public string GetClothes()
        {
            return "T-Shirt";
        }

        public string GetAccessories()
        {
            return "sun glasses";
        }
    }
}
