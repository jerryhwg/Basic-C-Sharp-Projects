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

        List<int> intList2 = new List<int>(new int[] {1, 2, 3, 4, 5});
        Console.WriteLine(intList2[1]);

        List<string> strList1 = new List<string>();
        strList1.Add("Hello");
        strList1.Add("Jesse");
        strList1.Remove("Jesse");
        Console.WriteLine(strList1[0]);

        Console.ReadLine();
    }
}