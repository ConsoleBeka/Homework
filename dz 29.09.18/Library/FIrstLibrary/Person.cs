using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrstLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            Age = age;
            LastName = lastName;
        }
    }
}
