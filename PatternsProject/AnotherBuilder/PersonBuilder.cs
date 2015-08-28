using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherBuilder
{
    class PersonBuilder : AbstractBuilder<Person>
    {
        private Person _person;

        public PersonBuilder()
        {
            _person = new Person();
        }

        public PersonBuilder WithAge(int age)
        {
            _person.Age = age;
            return this;
        }

        public PersonBuilder WithSurname(string surname)
        {
            _person.SurName = surname;
            return this;
        }

        public PersonBuilder WithName(string name)
        {
            _person.Name = name;
            return this;
        }

        public Person Build()
        {
            return this._person;
        }
    }
}
