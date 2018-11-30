using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObjectMethodBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            result1 = mathAdd(number1, number2);
            result2 = mathMultiply(number1, number2);
            result3 = mathDivide(number1, number2);

            Console.WriteLine("Input a number you want to do the math operations on.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another number you want to do the math operation on.");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Method 1 result: " + result1);
            Console.WriteLine("Method 2 result: " + result2);
            Console.WriteLine("Method 3 result: " + result3);
            Console.ReadLine();
        }
    }
}
