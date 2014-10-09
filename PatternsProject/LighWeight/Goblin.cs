using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LighWeight
{
    class Goblin : Unit
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 100;
            Picture = Image.FromFile(@"C:\Users\oleg.d\documents\visual studio 2010\Projects\GofDesignPatterns\LighWeight\Goblin.jpg");
        }
    }
}
