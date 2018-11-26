using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonyIncomeComp
{
    class Program
    {
        static void Main(string[] args)
        {
            int weeksYr = 52;
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            int person1HrRate = 10;
            Console.WriteLine("Hourly Rate = " + person1HrRate);
            int person1HrWeek = 40;
            Console.WriteLine("Hours worked per week = " + person1HrWeek);
            Console.WriteLine("Person 2");
            int person2HrRate = 8;
            Console.WriteLine("Hourly Rate = " + person2HrRate);
            int person2HrWeek = 40;
            Console.WriteLine("Hours worked per week = " + person2HrWeek);
            int persona1YrIncome = person1HrRate * person1HrWeek * weeksYr;
            Console.WriteLine("Annual salary of Person 1 = " + persona1YrIncome);
            int persona2YrIncome = person2HrRate * person2HrWeek * weeksYr;
            Console.WriteLine("Annual salary of Person 2 = " + persona2YrIncome);
            Console.WriteLine("Does Person 1 make more momeny than Person 2?");
            bool trueOrFalse = persona1YrIncome > persona2YrIncome;
            Console.WriteLine(trueOrFalse);
            Console.Read();
        }
    }
}
