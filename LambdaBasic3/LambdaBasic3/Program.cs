using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaBasic1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Employee employee = new Employee();
            List<Employee> empList = new List<Employee>()
            {
                new Employee { FName = "Bill", LName = "Gates", Id = 1 },
                new Employee { FName = "Steve", LName = "Jobs", Id = 2 },
                new Employee { FName = "Jeff", LName = "Bezos", Id = 3 },
                new Employee { FName = "Joe", LName = "Mara", Id = 4 },
                new Employee { FName = "Joe", LName = "Wang", Id = 5 },
                new Employee { FName = "Steven", LName = "Holmes", Id = 6 },
                new Employee { FName = "Mark", LName = "Zerkburg", Id = 7 },
                new Employee { FName = "Larry", LName = "Page", Id = 8 },
                new Employee { FName = "Tim", LName = "Cook", Id = 9 },
                new Employee { FName = "Jerry", LName = "Lee", Id = 10 }
            };
            List<Employee> empListJoe = empList.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in empListJoe)
            {
                Console.WriteLine($"{employee.FName} {employee.LName} {employee.Id}");
            }
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; set; }
    }
}
