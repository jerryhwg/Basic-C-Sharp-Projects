using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObjectMethodBasic2
{
    public class Program
    {
        static void Main()
        {
            Math.math(firstNumber: 3, secondNumber: 5);
        }
    }

    public class Math
    {
        public static void math(int firstNumber, int secondNumber)
        {
            int result = (firstNumber + 2);
            Console.WriteLine(result);
            Console.WriteLine(secondNumber);
            Console.ReadLine();
        }
           }
}
