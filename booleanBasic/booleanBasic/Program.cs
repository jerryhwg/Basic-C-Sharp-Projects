using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanBasic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is  your age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);
            //Console.WriteLine(ageNum);

            Console.WriteLine("Have you ever had a DUI? Answer true or false.");
            string dui = Console.ReadLine();
            //Console.WriteLine(dui);

            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();
            int ticketNum = Convert.ToInt32(ticket);
            //Console.WriteLine(ticketNum);

            bool ageQual = ageNum >= 15;
            bool duiQual = (dui == "false");
            bool ticketQual = ticketNum < 3;

            Console.WriteLine("Qualitifed?");
            bool resultQual = (ageQual && duiQual && ticketQual);
            Console.WriteLine(resultQual);

            Console.Read();
        }
    }
}
