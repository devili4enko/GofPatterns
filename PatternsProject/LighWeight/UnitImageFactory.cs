using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LighWeight
{
    class UnitImageFactory
    {
        public static Dictionary<Type, Image> UnitImages = new Dictionary<Type, Image>();

        public static Image GetDragonImage()
        {
            if (!UnitImages.ContainsKey(typeof(Dragon)))
            {
                UnitImages.Add(typeof(Dragon), Image.FromFile(@"C:\Users\oleg.d\documents\visual studio 2010\Projects\GofDesignPatterns\LighWeight\Dragon.jpg"));
            }

            return UnitImages[typeof (Dragon)];
        }

          public static Image GetGoblinImage()
        {
            if (!UnitImages.ContainsKey(typeof(Goblin)))
            {
                UnitImages.Add(typeof(Goblin), Image.FromFile(@"C:\Users\oleg.d\documents\visual studio 2010\Projects\GofDesignPatterns\LighWeight\Goblin.jpg"));
            }

            return UnitImages[typeof (Goblin)];
        }
    }
}
