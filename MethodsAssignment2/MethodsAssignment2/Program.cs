using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment2
{
    public class Program
    {
        public static void Main()
        {
            Integer integer = new Integer();

            Console.WriteLine("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the two numbers is: {0} ", integer.Sum(n1));
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            Decimal n2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The difference of the two numbers is: {0}", integer.Subtract(n2));
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The product of the two numbers is: {0}", integer.Multiply(Convert.ToInt32(n3)));
            Console.ReadLine();
        }
    }
    
}
