using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public interface IToyFactory
    {
        Bear GetBear();
        Cat GetCat();
    }
}
