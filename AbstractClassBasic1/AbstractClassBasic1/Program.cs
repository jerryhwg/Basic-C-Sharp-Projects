using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instantiate Employee class
            employee.FirstName = "Sample"; // inialize employee with one firstname, Firstname: property
            employee.LastName = "Student";
            employee.SayName(); // Call super class method (of Person class) on employee (instance, object)
            Console.ReadLine();
        }
    }
}
