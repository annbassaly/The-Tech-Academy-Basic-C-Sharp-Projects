using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");

            Console.WriteLine("What is your hourly rate?");
            int empOnehourlyrate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours do you work per week?");
            int empOnehoursworked = Convert.ToInt32(Console.ReadLine());

            int empOnetotalsalary = (empOnehourlyrate * empOnehoursworked) * 52;
  
            Console.WriteLine("Person 2");

            Console.WriteLine("What is your hourly rate?");
            int empTwohourlyrate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours do you work per week?");
            int empTwohoursworked = Convert.ToInt32(Console.ReadLine());
            int empTwototalsalary = (empTwohourlyrate * empTwohoursworked) * 52;
            Console.WriteLine("Annual salary of Person 1: " + empOnetotalsalary);
            Console.WriteLine("Annual salary of Person 2: " + empTwototalsalary);

            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            bool trueorFalse = empOnetotalsalary > empTwototalsalary;
            Console.WriteLine(trueorFalse.ToString());
            Console.ReadLine();
        }
    }
}
