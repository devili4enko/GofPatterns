using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LighWeight
{
    class LightweightGoblin : Unit
    {
        public LightweightGoblin()
        {
            Name = "Goblin";
            Health = 100;
            Picture = UnitImageFactory.GetGoblinImage();
        }
    }
}
