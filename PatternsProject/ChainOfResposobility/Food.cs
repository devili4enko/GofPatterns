using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResposobility
{
    public class Food
    {
        public string Name { get; set; }
        public List<string> Ingradients { get; set; }

        public Food()
        {
            Ingradients= new List<string>();
        }
    }
}
