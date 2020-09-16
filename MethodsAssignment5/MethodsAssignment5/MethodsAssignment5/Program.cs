using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment5
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Division division = new Division();
            Console.WriteLine("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            division.Divide(n1, out int total);
            Console.WriteLine("The difference of the two numbers is: {0}", total);
            Console.ReadLine();
        }
    }
}
