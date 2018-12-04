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
            string strResult3 = new string(new char[] { });
            strResult3 = Math.math(number3);
            //(wrong) int strResult3 = new int();
            //(wrong) strResult3 = Convert.ToInt32(Math.math(number3));
            Console.WriteLine(strResult3);

            Console.ReadLine();
        }
    }
}