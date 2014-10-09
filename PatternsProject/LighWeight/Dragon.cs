using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LighWeight
{
    class Dragon : Unit
    {
        public Dragon()
        {
            Name = "Dragon";
            Health = 250;
            Picture = Image.FromFile(@"C:\Users\oleg.d\documents\visual studio 2010\Projects\GofDesignPatterns\LighWeight\Dragon.jpg");
        }
    }
}
