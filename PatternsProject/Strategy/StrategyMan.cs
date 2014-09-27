using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class StrategyMan
    {
        private IWearingStratery _wearingStrategy = new DefaultWearingStrategy();

        public void ChangeWearingStratedy(IWearingStratery wearingStratery)
        {
            _wearingStrategy = wearingStratery;
        }

        public void GoOutside()
        {
            var clothes = _wearingStrategy.GetClothes();
            var accessories = _wearingStrategy.GetAccessories();
            Console.WriteLine("Today {0} weather and I wear {1} with {2}", _wearingStrategy.weather, clothes, accessories);

        }
        
    }
}
