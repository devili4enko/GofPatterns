using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class RainWearingStrategy: IWearingStratery
    {
        public string weather { get; set; }

        public RainWearingStrategy()
        {
            weather = "rain";
        }

        public string GetClothes()
        {
            return "coat";
        }

        public string GetAccessories()
        {
            return "umbrella";
        }
    }
}
