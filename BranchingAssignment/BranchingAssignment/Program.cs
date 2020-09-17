using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            int maximum = 50;

            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageWidth + packageHeight + packageLength > maximum)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express.");
                    Console.ReadLine();
                }
            else if (packageWidth + packageHeight + packageLength <= maximum)
                {
                    int packageTotal = (packageWidth * packageHeight * packageLength) * packageWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + packageTotal);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
                    
            
        }
    }
}
