using System;

namespace branchingBasic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                int sumDimension = width + height + length;
                if (sumDimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    double quote = (sumDimension * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ". Thank you");
                }
            }
            Console.ReadLine();
        }
    }
}
