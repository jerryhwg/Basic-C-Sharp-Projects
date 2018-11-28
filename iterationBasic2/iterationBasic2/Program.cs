using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        // Assignment 1
        string[] names = { "Jesse", "Jerry", "Tom" };
        Console.WriteLine("Say \"Hi\" to eaveryone");
        string greet = Console.ReadLine();

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(greet + " " + names[i] + "!");
        }

        // Assignment 2 & 3
        Console.WriteLine("\nGuess my number?");
        int number = Convert.ToInt32(Console.ReadLine());
        bool myNumber = number == 7;

        do
        {
            switch (number)
            {
                case 7:
                    Console.WriteLine("Your guess is right! \n");
                    myNumber = true;
                    break;
                default:
                    Console.WriteLine("Your guess is wrong. Try again!");
                    Console.WriteLine("Guess my number?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

        while (!myNumber);

        //Assignment 4

        Console.WriteLine("Your test result: ");
        int[] myScores = { 70, 50, 45, 80, 90 };
        int failScore = 70;

        for (int j = 0; j < myScores.Length; j++)
        {
            if (myScores[j] < failScore)
            {
                Console.WriteLine("You failed with your score " + myScores[j] + "!");
            }
        }

        Console.ReadLine();
        }
    }