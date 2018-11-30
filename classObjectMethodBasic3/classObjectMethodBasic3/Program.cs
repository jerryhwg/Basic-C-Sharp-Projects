using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObjectMethodBasic3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 12;
            int result1 = new int();
            result1 = Math.math(number1);
            Console.WriteLine(result1);

            decimal number2 = 10;
            int result2 = new int();
            result2 = Convert.ToInt32(Math.math(number2));
            Console.WriteLine(result2);

            string number3 = "20";
            int strResult3 = new int();
            strResult3 = Convert.ToInt32(Math.math(number3));
            Console.WriteLine(strResult3);

            Console.ReadLine();
        }
    }
    public class Math
    {
        public static int math(int number1)
        {
            int result1 = (number1 + 3);
            return result1;
        }

        public static decimal math(decimal number2)
        {
            decimal result2 = (number2 + 10);
            return result2;
        }

        public static string math(string number3)
        {
            int newNum3 = Convert.ToInt32(number3);
            int result3 = (newNum3 + 20);
            string strResult3 = Convert.ToString(result3);
            return strResult3;
        }
    }
}