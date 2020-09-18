using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Mark\n", "Donna\n", "Bill\n", "Jane\n" };

        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();

         for (int j = 0; j < names.Length; j++)
        {
            Console.WriteLine("\n");
            names[j] += yourName;
            Console.WriteLine(names[j]);
            Console.ReadLine();
        }
    }
}
