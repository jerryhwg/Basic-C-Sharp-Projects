using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList1 = new List<int>();
        intList1.Add(5);
        intList1.Add(10);
        intList1.Remove(10);
        Console.WriteLine(intList1[0]);

        List<string> intList2 = new List<string>();
        intList2.Add("Hello");
        intList2.Add("Jesse");
        intList2.Remove("Jesse");
        Console.WriteLine(intList2[0]);

        Console.ReadLine();
    }
}