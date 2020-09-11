using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        string[] names = { "Mark", "Donna", "Bill", "Jane" };

        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();
  
        foreach (string items in names)
        {
            Console.WriteLine(items + yourName);
        }
        Console.ReadLine();

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine("\n");
        //    names[j] += yourName;
        //    Console.WriteLine(names[j]);
        //    Console.ReadLine();
        //}
        }
    }

