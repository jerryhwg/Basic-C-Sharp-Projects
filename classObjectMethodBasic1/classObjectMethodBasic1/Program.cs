using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObjectMethodBasic1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("What number do you want to do the math operations on?");
            double number = Convert.ToInt32(Console.ReadLine());

            double result1 = new double();
            result1 = Math.Addition(number);
            double result2 = new double();
            result2 = Math.Multiplication(number);
            double result3 = new double();
            result3 = Math.Division(number);

            Console.WriteLine("Addition result: " + result1);
            Console.WriteLine("Multiplication result: " + result2);
            Console.WriteLine("Division result: " + result3);
            Console.ReadLine();
        }
    }
}
