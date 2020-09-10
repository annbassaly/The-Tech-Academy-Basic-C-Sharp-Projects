using System;


class Program
{
    static void Main()
    {
        string[] names = { "Ann", "Jeff", "Beth", "Mark" };
        string input = "";

        Console.WriteLine("What is your name?");
        input = Console.ReadLine();

        if (names [0] == input)
        {
            Console.WriteLine("Welcome " + input + "!");
        }
        else
        {
            Console.WriteLine("Your name is not on the list");
        }
        Console.ReadLine();
    }
            
}

