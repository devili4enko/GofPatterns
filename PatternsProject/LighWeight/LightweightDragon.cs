using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LighWeight
{
    class LightweightDragon : Unit
    {
        public LightweightDragon()
        {
            Name = "Dragon";
            Health = 250;
            Picture = UnitImageFactory.GetDragonImage();
        }
    }
}
