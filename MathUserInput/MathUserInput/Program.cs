using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUserInput
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Please enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The total is " + num1 * 50);

            //Console.WriteLine("Please enter a number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num2Total = num2 + 25;
            //Console.WriteLine("The total is " + num2Total);


            //Console.WriteLine("Please enter a number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //double num3Total = num3 / 12.5;
            //Console.WriteLine("The total is " + num3Total);

            //Console.WriteLine("Please enter a number: ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((m > 50));

            Console.WriteLine("Please enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num4Total = num4 % 7;
            Console.WriteLine("The remainder is " + num4Total);
            Console.ReadLine();


        }
    }
}
