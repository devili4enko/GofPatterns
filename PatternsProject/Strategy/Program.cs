using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();

            man.GoOutSide();

            var sMan = new StrategyMan();
            sMan.GoOutside();

            sMan.ChangeWearingStratedy(new SnowWearingStrategy());
            sMan.GoOutside();

            sMan.ChangeWearingStratedy(new RainWearingStrategy());
            sMan.GoOutside();

            sMan.ChangeWearingStratedy(new SunWearingStrategy());
            sMan.GoOutside();
        }
    }
}
