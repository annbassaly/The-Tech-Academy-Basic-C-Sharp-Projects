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
            int empOnehourlyrate = 15;
            Console.WriteLine("Hourly Rate? " + empOnehourlyrate);
            int empOnehoursworked = 40;
            Console.WriteLine("Hours worked per week? " + empOnehoursworked);
            int empOnetotalsalary = (empOnehourlyrate * empOnehoursworked) * 52;
  
            Console.WriteLine("Person 2");
            int empTwohourlyrate = 20;
            Console.WriteLine("Hourly Rate? " + empTwohourlyrate);
            int empTwohoursworked = 40;
            Console.WriteLine("Hours worked per week? " + empTwohoursworked);
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
