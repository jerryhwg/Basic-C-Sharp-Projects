using System;

namespace loopBasic2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess my weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            bool myWeight = weight == 68;

            while (!myWeight)
            {
                switch (weight)
                {
                    case int n when (n < 68 && n > 65):
                        Console.WriteLine("I am heavier than that! Try again");
                        Console.WriteLine("Guess my weight?");
                        weight = Convert.ToInt32(Console.ReadLine());
                        break;
                    case int n when (n < 75 && n > 68):
                        Console.WriteLine("I am lighter than that! Try again");
                        Console.WriteLine("Guess my weight?");
                        weight = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 68:
                        Console.WriteLine("You guessed my weight correctly! You know me well!");
                        myWeight = true;
                        break;
                    default:
                        Console.WriteLine("Your guess is not close yet");
                        Console.WriteLine("Guess my weight?");
                        weight = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.Read();
        }
    }
}
