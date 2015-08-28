using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var presonBuilder = new PersonBuilder();

            var person = presonBuilder.WithAge(18).WithName("Alex").Build();

            Console.WriteLine(person);
        }
    }
}
