using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] fruitArray = { "Apple", "Banana", "Orange", "Pear", "Grape" };

        Console.WriteLine("Select a number for your fruit choice in 0 - 4.");
        int i = Convert.ToInt32(Console.ReadLine());

        if(i < fruitArray.Length)
        {
            Console.WriteLine("Your choice is " + i + ". " + fruitArray[i] + ".");
        }
        else
        {
            Console.WriteLine("Your choice is not valid. Choice number must be in 0 - 4");
        }
        

        int[] numArray = { 100, 200, 300, 400, 500 };

        Console.WriteLine("Select a number for your score in 0 - 4.");
        int j = Convert.ToInt32(Console.ReadLine());

        if (j < numArray.Length)
        {
            Console.WriteLine("Your choice is " + j + ". " + numArray[j] + ".");
        }
        else
        {
            Console.WriteLine("Your choice is not valid. Choice number must be in 0 - 4");
        }

        List<string> fruitList = new List<string>();
        fruitList.Add("Apple");
        fruitList.Add("Banana");
        fruitList.Add("Orange");
        fruitList.Add("Pear");
        fruitList.Add("Grape");

        Console.WriteLine("Select a number for your fruit choice in 0 - 4.");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k < fruitList.Count)
        {
            Console.WriteLine("Your choice is " + k + ". " + fruitList[k] + ".");
        }
        else
        {
            Console.WriteLine("Your choice is not valid.  Choice number must be in 0 - 4");
        }

        Console.ReadLine();
    }
}