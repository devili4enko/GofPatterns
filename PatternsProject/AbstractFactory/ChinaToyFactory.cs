using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class ChinaToyFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new ChinaBear();
        }

        public Cat GetCat()
        {
            return  new ChinaCat();
        }
    }
}
