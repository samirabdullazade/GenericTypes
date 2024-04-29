using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee(string name, string surname, int age, decimal salary) : base(name, surname, age)
        {
            Salary = salary;
        }
    }
}