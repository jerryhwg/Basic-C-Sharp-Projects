using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        string[] fruitArray = { "apple", "banana", "orange", "pear", "grape" };
        //Console.WriteLine(fruitArray[0]);

        Console.WriteLine("Type an array Number in 0 ~ 4 for a fruit");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("You will get " + fruitArray[0] + ".");
        }
        else if (number == 1)
        {
            Console.WriteLine("You will get " + fruitArray[1] + ".");
        }
        else if (number == 2)
        {
            Console.WriteLine("You will get " + fruitArray[2] + ".");
        }
        else if (number == 3)
        {
            Console.WriteLine("You will get " + fruitArray[3] + ".");
        }
        else if (number == 4)
        {
            Console.WriteLine("You will get " + fruitArray[4] + ".");
        }
        else
        {
            Console.WriteLine("You did not follow my instruction so no fruit for you.");
        }

        Console.WriteLine("Next question");

        int[] numArray = { 100, 200, 300, 400, 500 };
        //Console.WriteLine(numArray[0]);

        Console.WriteLine("Type an array Number in 0 ~ 4 for a number");

        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine("Your number: " + numArray[0]);
        }
        else if (num == 1)
        {
            Console.WriteLine("Your number: " + numArray[1]);
        }
        else if (num == 2)
        {
            Console.WriteLine("Your number: " + numArray[2]);
        }
        else if (num == 3)
        {
            Console.WriteLine("Your number: " + numArray[3]);
        }
        else if (num == 4)
        {
            Console.WriteLine("Your number: " + numArray[4]);
        }
        else
        {
            Console.WriteLine("You did not follow my instruction so no value.");
        }

        Console.WriteLine("Last question");

        List<string> fruitList = new List<string>();
        fruitList.Add("Apple");
        fruitList.Add("Banana");
        fruitList.Add("Orange");
        fruitList.Add("Pear");
        fruitList.Add("Grape");
        //Console.WriteLine(fruitList[0]);

        Console.WriteLine("Type a list Number in 0 ~ 4 for a fruit");

        int listNum = Convert.ToInt32(Console.ReadLine());

        if (listNum == 0)
        {
            Console.WriteLine("You will get " + fruitList[0] + ".");
        }
        else if (listNum == 1)
        {
            Console.WriteLine("You will get " + fruitList[1] + ".");
        }
        else if (listNum == 2)
        {
            Console.WriteLine("You will get " + fruitList[2] + ".");
        }
        else if (listNum == 3)
        {
            Console.WriteLine("You will get " + fruitList[3] + ".");
        }
        else if (listNum == 4)
        {
            Console.WriteLine("You will get " + fruitList[4] + ".");
        }
        else
        {
            Console.WriteLine("You did not follow my instruction so no fruit for you.");
        }

        Console.WriteLine("No more question. Have a good day!");
        Console.ReadLine();
        }
    }
