using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class GermanToyFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new GermanBear();
        }

        public Cat GetCat()
        {
            return new GermanCat();
        }
    }
}
