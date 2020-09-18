using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        {
            string[] names = { "Ann", "Jeff", "Beth", "Mark" };
            int i;

            Console.WriteLine("Pick a number between 0 and 3");
            int input = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i < names.Length; i++)
            {
                if (input >= 0 && input < 4)
                {
                    Console.WriteLine("Welcome {0}", names[input]);
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("You need to pick a number between 0 and 3");
                }
                {
                    int[] numbers = { 0, 1, 2, 3 };
                    int j;

                    Console.WriteLine("Pick a number between 0 and 3");
                    int input2 = Convert.ToInt32(Console.ReadLine());


                    for (j = 0; j < numbers.Length; j++)
                    {
                        if (input2 >= 0 && input2 < 4)
                        {
                            Console.WriteLine("You picked number {0}", numbers[input2]);
                            Console.ReadLine();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("You need to pick a number between 0 and 3");
                        }
                    }
                }

            }
        }

        

    }
}   

