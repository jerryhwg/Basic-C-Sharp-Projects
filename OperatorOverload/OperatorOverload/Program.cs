using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Final
            Employee dave = new Employee(); // instantiate for employee 'dave'
            dave.Id = 100; // assign ID for 'dave'
            Employee greg = new Employee(); // instantiate for employee 'greg'
            greg.Id = 200; // assign ID for 'greg'
            bool compare = (dave == greg); // Use operator overload (==) defined in Employee class
            if (compare)
            {
                Console.WriteLine("The two employee Ids match");
            }
            else
            {
                Console.WriteLine("The two employee IDs don't match");
            }

            // Option 1
            //List<Employee> empList = new List<Employee>()
            //{
            //    new Employee{ Id = 100 },
            //    new Employee{ Id = 200 },
            //    new Employee{ Id = 300 }
            //};

            //bool compare = empList[0] == empList[1];
            //if (compare)
            //{
            //    Console.WriteLine("The Ids match");
            //}
            //else
            //{
            //    Console.WriteLine("The IDs don't match");
            //}

            // Option 2
            //Employee employee = new Employee();
            //List<Employee> empList = new List<Employee>()
            //{
            //    new Employee {FName = "Bill", LName = "Gates", Id = 100}
            //};

            // Option 3
            //Employee employee = new Employee();
            //int employee1 = 100;
            //int employee2 = 200;
            //Console.WriteLine($"Employee 1 ID is {employee1}");
            //Console.WriteLine($"Employee 2 ID is {employee2}");

            //bool idComparison = (employee1 == employee2);
            //Console.WriteLine($"employee 1 ID and employee 2 ID is same: {idComparison}");

            Console.ReadLine();
        }
    }
}