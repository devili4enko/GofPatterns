using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LighWeight
{

    class Army<T, U>
        where U : Unit, new()
        where T : Unit, new()
    {
        public List<Unit> Units { get; set; }

        public Army()
        {
            Units = new List<Unit>();
        }

        public void SetArmy()
        {
            for (int i = 0; i < 100; i++)
                Units.Add(new T());
            
            for (int i = 0; i < 150; i++)
                Units.Add(new U());
        }
    }
}
