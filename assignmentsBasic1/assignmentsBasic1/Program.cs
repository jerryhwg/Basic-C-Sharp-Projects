using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Assignment 1: Create a one-dimensional Array of strings. Ask the user to input some text. 
        // Create a loop that goes through each string in the Array, adding the user’s text to the string. 
        // Then create a loop that prints off each string in the Array on a separate line.
        string[] names = { "Jesse", "Jerry", "Tom" };
        Console.WriteLine("Say \"Hi\" to eaveryone");
        string greet = Console.ReadLine();

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(greet + " " + names[i] + "!");
        }

        // ASsignment 2: Create an infinite loop.
        // Assignment 3: Fix the infinite loop so it will execute.
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

        // Assignment 4: Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

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

        // Assignment 5: Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

        Console.WriteLine("\nHow many treasures have you found?");
        int myTreasures = Convert.ToInt32(Console.ReadLine());

        while (myTreasures <= 3)
        {
            Console.WriteLine("\nKeep working! How many treasures have you found?");
            myTreasures = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Good jobs, you have found enough treasures!");

        // Assignment 6: Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
        // Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
        // Assignment 7: Add code to that above loop that tells a user if they put in text that isn’t in the List.
        // Assignment 8: Add code to that above loop that stops it from executing once a match has been found.

        string[] fruits = { "apple", "banana", "orange", "pear", "grape" };
        Console.WriteLine("\nChoose what fruit you want in my fruit container?");
        string choice = Console.ReadLine();

        while (! fruits.Contains(choice))
        {
            Console.WriteLine("Your choice is not valid");
            Console.WriteLine("\nChoose what fruit you want in my fruit container?");
            choice = Console.ReadLine();
        }

        for (int k = 0; k < fruits.Length; k++)
        {
            if (fruits[k] == choice)
            {
                Console.WriteLine("Yes I have " + fruits[k] + ".");
                break;
            }
        }

        // Assignment 9: Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. 
        // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
        // Assignment 10: Add code to that above loop that tells a user if they put in text that isn’t in the List.

        string[] city = { "portland", "seattle", "chicago", "newyork", "seattle" };
        Console.WriteLine("\nFInd a city name that is twice listed in the list.");
        string cityQuery = Console.ReadLine();

        var duplicates = city
            .GroupBy(i => i)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key);

        if (city.Contains(cityQuery))
        {
            foreach (var l in duplicates)
                if (cityQuery == l)
                {
                    // index of first occurence
                    //int index = Array.IndexOf(city, cityQuery);
                    //Console.WriteLine("{0} is listed twice in the list at index {1}.", cityQuery, index);
                    for (int i = 0; i < city.Length; i++)
                    {
                        if (cityQuery == city[i])
                        {
                            Console.WriteLine("Correct, " + cityQuery + " is listed respectively in index " + i);
                        }
                    }
                    //Console.WriteLine("Correct. " + cityQuery + " is listed twice in the list at index."
                    //break;
                }
                else if (cityQuery != l)
                {
                    Console.WriteLine(cityQuery + " is not listed twice in the list.");
                    break;
                }
        }
        else
        {
            Console.WriteLine("The city you queried is not in the city list.");
        }

        // Assignment 11: Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and
        // displays a message showing the string and whether or not it has already appeared in the list.

        List<string> fnames = new List<string>() { "Jesse", "Jerry", "Tom", "Jesse" };
        List<string> duplicateName = new List<string>();
        Console.WriteLine("\nHere are everyone's name. Jesse, Jerry, Tom" );

        Console.WriteLine("\nFInd which name is listed twice in the name list.");
        string nameQuery = Console.ReadLine();

        foreach (var name in fnames)
        {
            if (nameQuery == name)
            {
                duplicateName.Add(name);
            }
        }

        if (duplicateName.Count() > 1)
        {
            for (int i = 0; i < fnames.Count; i++)
            {
                if (nameQuery == fnames[i])
                {
                    Console.WriteLine("Yes, the name " + nameQuery + " is duplicate in list and listed in the index " + i);
                }
            }
        }
        else
        {
            Console.WriteLine("The name is not listed duplicate in the list");
        }

        Console.ReadLine();
    }
}