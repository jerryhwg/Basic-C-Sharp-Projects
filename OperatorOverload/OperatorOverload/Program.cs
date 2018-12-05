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
            Employee employee = new Employee();
            int employee1 = 100;
            int employee2 = 200;
            Console.WriteLine($"Employee 1 ID is {employee1}");
            Console.WriteLine($"Employee 2 ID is {employee2}");

            bool idComparison = (employee1 == employee2);
            Console.WriteLine($"employee 1 ID and employee 2 ID is same: {idComparison}");
            Console.ReadLine();
        }
    }
}
