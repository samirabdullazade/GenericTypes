using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    internal class Person
    {
        private static int _idCounter = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Id = _idCounter++;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
