using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number.");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\jerry\Logs\number.txt", number);

            string read_number = File.ReadAllText(@"C:\Users\jerry\Logs\number.txt");
            Console.WriteLine(read_number);
            Console.Read();
        }
    }
}
