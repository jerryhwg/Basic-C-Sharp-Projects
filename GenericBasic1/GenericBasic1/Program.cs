using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); // Instantiate an Employee object (employee) with type <string> as its generic parameter(type)
            // Assign a list of strings as the property value of Things
            employee.Things = new List<string>() { "FirstThing", "SecondThing", "ThirdThing" };
            //employee.Things.Add("FirstThing"); 
            //employee.Things.Add("SecondThing");
            //employee.Things.Add("ThridThing");

            Employee<int> employeeID = new Employee<int>(); // Instantiate an Employee object (employeeID) with type <int> as its generic parameter(type)
            // Assign a list of integers as the propery value of Things
            employeeID.Things = new List<int>() { 100, 200, 300 };
            //employeeID.Things.Add(100); 
            //employeeID.Things.Add(200);
            //employeeID.Things.Add(300);

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employeeID.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
