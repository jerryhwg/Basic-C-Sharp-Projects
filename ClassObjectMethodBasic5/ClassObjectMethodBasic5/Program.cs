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
}
