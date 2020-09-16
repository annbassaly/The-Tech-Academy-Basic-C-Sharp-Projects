﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment4
{
    class Program
    {
        public static void Main()
        { 
        try
        {
            Console.WriteLine("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter another number if you would like: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the two numbers is : {0} ", Integer.Sum(n1, n2));
            }
   
    
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
                Console.ReadLine();
            }
        }    
            
        }
    
}
