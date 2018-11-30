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
            int number = Convert.ToInt32(Console.ReadLine());

            int result1 = new int();
            result1 = Sum(result1);
            int result2 = new int();
            result2 = Product(result2);
            int result3 = new int();
            result3 = Quotient(result3);

            Console.WriteLine("Math 1 result: " + result1);
            Console.WriteLine("Math 2 result: " + result2);
            Console.WriteLine("Math 3 result: " + result3);
            Console.ReadLine();
        }

        public static int Sum(int number)

        {
            int result1 = number + 2;
            return result1;
        }

        public static int Product(int number)
        {
            int result2 = number * 2;
            return result2;
        }

        public static int Quotient(int number)
        {
            int result3 = number / 2;
            return result3;
        }
    }
}
