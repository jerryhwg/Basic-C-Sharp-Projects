using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            Console.WriteLine("Choose a number.");
            int t = Convert.ToInt32(Console.ReadLine());

            DateTime dt1 = dt.AddHours(+t);
            Console.WriteLine(dt1);
            Console.Read();
        }
    }
}
