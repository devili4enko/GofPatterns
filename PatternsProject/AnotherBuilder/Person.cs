using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherBuilder
{
   public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }

        public Hobbie Hobbie { get; set; }

        public override string ToString()
        {
            return String.Format("Hi I'm {0} and I {0} years old", Name, Age);
        }

    }
}
