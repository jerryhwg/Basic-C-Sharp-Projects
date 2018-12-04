using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic1
{
    public class Employee : Person, IQuittable // Person: class inheritance, IQuittable: interface inheritiance
    {
        public new void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        public void Quit()
        {
            Console.WriteLine("Quit Quit");
        }
    }
}
