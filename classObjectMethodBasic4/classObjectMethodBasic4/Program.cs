using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObjectMethodBasic4
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number for first number to do a math on: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input a number for second number to do a math on or you need not enter one: ");
            int number2 = 0;
            string input2 = Console.ReadLine();

            if (input2.Equals(string.Empty))
            {
                Console.WriteLine("Math result: " + Math.math(number1));
            }
            else
            {
                if (!Int32.TryParse(input2, out number2))
                {
                    Console.WriteLine("Number 2 was entered incorrectly");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Math result: " + Math.math(number1, number2));
                }
            }

            Console.ReadLine();
        }
    }
    public class Math
    {
        public static int math(int number1, int number2 = 3)
        {
            int result1 = number1 + number2;
            return result1;
        }
    }
}
