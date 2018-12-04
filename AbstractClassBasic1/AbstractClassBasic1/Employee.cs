using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassBasic1
{
    public class Employee : Person // inheritance
    {
        public new void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
