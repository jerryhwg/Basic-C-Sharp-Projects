using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObjectMethodBasic3
{
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
