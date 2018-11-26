using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Basic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input your number to multiply it by 50");
            string yourNum1 = Console.ReadLine();
            int Number1 = Convert.ToInt32(yourNum1);
            int product = 50 * Number1;
            Console.WriteLine("Result = " +product);

            Console.WriteLine("Input your number to add it to 25");
            string yourNum2 = Console.ReadLine();
            int Number2 = Convert.ToInt32(yourNum2);
            int total = 25 + Number2;
            Console.WriteLine("Result = " + total);

            Console.WriteLine("Input your number to divide it by 12.5");
            string yourNum3 = Console.ReadLine();
            double Number3 = Convert.ToDouble(yourNum3);
            double quotient = Number3 / 12.5;
            Console.WriteLine("Result = " + quotient);

            Console.WriteLine("Input your number to compare it with 50");
            string yourNum4 = Console.ReadLine();
            int Number4 = Convert.ToInt32(yourNum4);
            bool trueOrFalse = Number4 > 50;
            Console.WriteLine("Result = " + trueOrFalse);

            Console.WriteLine("Input your number to calculate the remainder of it divided by 7");
            string yourNum5 = Console.ReadLine();
            int Number5 = Convert.ToInt32(yourNum5);
            int remainder = Number5 % 7;
            Console.WriteLine("Result = " + remainder);

            Console.ReadLine();
        }
    }
}
