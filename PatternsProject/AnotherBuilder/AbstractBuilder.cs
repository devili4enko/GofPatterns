using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherBuilder
{
    interface AbstractBuilder<T> where T: class 
    {
        T Build();

        T Build(T instance);
    }
}
