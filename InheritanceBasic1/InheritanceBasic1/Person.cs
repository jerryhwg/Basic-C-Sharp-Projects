using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic1
{
    public class Person
    {
        public string FirstName { get; set; } // property of Person
        public string LastName { get; set; } // Property of Person

        public void SayName() // void method: no return need, just works here.
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
