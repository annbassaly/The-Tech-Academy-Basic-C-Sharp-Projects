using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? ");
            int currentAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI (true or false)? ");
            bool hasDui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have? ");
            int speedTickets = Convert.ToInt32(Console.ReadLine());

            bool isQualified = (currentAge > 15 && hasDui==false && speedTickets <= 3);
            Console.WriteLine("Qualified? " + isQualified);
            Console.ReadLine();
        }
    }
}
