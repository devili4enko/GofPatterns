using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Adapter : INewElectisitySystem
    {
        private readonly OldElectricitySystem _adaptee;

        public Adapter(OldElectricitySystem adaptee)
        {
            _adaptee = adaptee;
        }

        public string MatchWideSocket()
        {
            return _adaptee.MatchThinSocket();
        }
    }
}
