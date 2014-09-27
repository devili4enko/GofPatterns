using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class NewElectrisitySystem : INewElectisitySystem
    {
        public string MatchWideSocket()
        {
            return "220V";
        }
    }
}
