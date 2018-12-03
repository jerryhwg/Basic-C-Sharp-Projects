using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectMethodBasic5
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number for a division math operation: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int output;

            Math.Div(number, out output);
        
            Console.ReadLine();
        }
    }

    public static class Math
    {
        public static void Div(int number, out int output)
        {
            int result = (number / 2);
            int temp = 2;
            output = temp;
            Console.WriteLine($"Your entered number {number} divided by 2 is {result}");
        }
    }
}
