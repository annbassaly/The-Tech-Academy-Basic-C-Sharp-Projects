using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 7;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 5. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 10. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 15. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed the number 7. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
