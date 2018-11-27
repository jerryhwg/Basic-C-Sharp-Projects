using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // String manipulation example
            string greeting1 = "Hello! ";
            string greeting2 = "How are you? ";
            Console.WriteLine("What your name? ");
            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine(greeting1 + greeting2 + name);

            // StringBuilder example
            StringBuilder sentence = new StringBuilder();
            sentence.Append("Welcome! \t Nice to meet you! \n");
            sentence.Append("Have a great day!");
            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
