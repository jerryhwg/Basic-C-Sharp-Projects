using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instantiate Employee class
            employee.FirstName = "Sample"; // inialize employee with one firstname, Firstname: property
            employee.LastName = "Student";
            employee.SayName(); // Call super class method (of Person class) on employee (instance, object)
            employee.Quit(); // interface inheritnance

            IQuittable instance = new YQuit(); // Polymorphism / Calling a specific interface
            instance.Quit();

            Console.ReadLine();
        }
    }
}
