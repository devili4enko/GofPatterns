using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class DefaultWearingStrategy : IWearingStratery
    {
        public string weather { get; set; }

        public DefaultWearingStrategy()
        {
            weather = "default";
        }

        public string GetClothes()
        {
            return "Shirt";
        }

        public string GetAccessories()
        {
            return "nothing";
        }
    }
}
