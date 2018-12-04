using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodBasic5
{
    public class Math
    {
        public static void Div(int number)
        {
            int result = (number / 2);
            Console.WriteLine($"Your entered number {number} divided by 2 is {result}");
        }

        public static void Div(int number, out int output)
        {
            int result = (number / 2);
            //int temp = 2;
            //output = temp;
            Console.WriteLine("Enter an output parameter:");
            output = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your entered number {number} divided by 2 is {result}");
            Console.WriteLine($"Output value is {output}");
        }
    }
}