using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
        string[] city = { "portland", "seattle", "chicago", "newyork", "seattle" };
        Console.WriteLine("\nFInd a city name that is twice listed in the list.");
        string cityQuery = Console.ReadLine();

        //int index = Array.IndexOf(city, cityQuery);
        //Console.WriteLine("{0} is listed twice in the list at index {1}.", cityQuery, index);
        //Console.ReadLine();

        for (int i = 0; i < city.Length; i++)
        {
            if (cityQuery == city[i])
            {
                Console.WriteLine(i);
            } 
        }

        Console.ReadLine();

        } 
    }