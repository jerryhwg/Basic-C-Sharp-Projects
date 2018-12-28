using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructBasic1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Number data = new Number(); // instantiate, create an object 'data' with data type 'Number'
            data.Amount = 100; // assign an amount to 'data' object(instance)
            Console.WriteLine(data.Amount); // print the amount to the console
            Console.ReadLine();
        }
    public struct Number // create a new struct called Number (value type)
    {
        public decimal Amount { get; set; } // property 'Amount' with decimal datatype
    }
        
    }
}
