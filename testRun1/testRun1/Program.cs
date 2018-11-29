using System;

    class Program
    {
        static void Main()
        {
        string[] city = { "portland", "seattle", "chicago", "newyork", "seattle" };
        Console.WriteLine("\nFInd a city name that is twice listed in the list.");
        string cityQuery = Console.ReadLine();

        int index = -1;
        do
        {
            index = Array.IndexOf(city, cityQuery, index + 1);
            System.Console.WriteLine(index);
        } while (-1 != index);

        Console.ReadLine();

        } 
    }