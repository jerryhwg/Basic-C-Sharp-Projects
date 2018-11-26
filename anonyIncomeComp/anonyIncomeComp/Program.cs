using System;

namespace anonyIncomeComp
{
    class Program
    {
        static void Main()
        {
            int weeksYr = 52;
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Person 1 Hourly Rate?");
            string person1HrRate = Console.ReadLine();
            int person1HrRateNum = Convert.ToInt32(person1HrRate);
            //Console.WriteLine("Person 1 Hourly Rate = " + person1HrRateNum);
            Console.WriteLine("Person 1 Hours Worked Per Week?");
            string person1HrWeek = Console.ReadLine();
            int person1HrWeekNum = Convert.ToInt32(person1HrWeek);
            //Console.WriteLine("Person 1 Hours worked per week = " + person1HrWeekNum);
            int person1WkIncome = person1HrRateNum * person1HrWeekNum;
            Console.WriteLine("Person 1 weekly income = " + person1WkIncome);

            Console.WriteLine("Person 2");
            Console.WriteLine("Person 2 Hourly Rate?");
            string person2HrRate = Console.ReadLine();
            int person2HrRateNum = Convert.ToInt32(person2HrRate);
            //Console.WriteLine("Person 2 Hourly Rate = " + person2HrRateNum);
            Console.WriteLine("Person 2 Hours Worked Per Week?");
            string person2HrWeek = Console.ReadLine();
            int person2HrWeekNum = Convert.ToInt32(person2HrWeek);
            //Console.WriteLine("Person 2 Hours worked per week = " + person2HrWeekNum);
            int person2WkIncome = person2HrRateNum * person2HrWeekNum;
            Console.WriteLine("Person 2 weekly income = " + person1WkIncome);
            int person1YrIncome = person1HrRateNum * person1HrWeekNum * weeksYr;

            Console.WriteLine("Annual salary of Person 1 = " + person1YrIncome);
            int person2YrIncome = person2HrRateNum * person2HrWeekNum * weeksYr;
            Console.WriteLine("Annual salary of Person 2 = " + person2YrIncome);
            Console.WriteLine("Does Person 1 make more momeny than Person 2?");
            bool trueOrFalse = person1YrIncome > person2YrIncome;
            Console.WriteLine(trueOrFalse);

            Console.ReadLine();
        }
    }
}
