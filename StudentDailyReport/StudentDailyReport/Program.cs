using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
 
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You are on " + yourCourse);

            Console.WriteLine("What page number:");
            string pageNumber = Console.ReadLine();
            int pageNumb = Convert.ToInt32(pageNumber);
            Console.WriteLine("You are on page number " + pageNumber);

            bool needHelp = true;
            needHelp = !needHelp;
            Console.WriteLine("Do you need help with anything? Please answer \"true or false\"");
            needHelp = Convert.ToBoolean(Console.ReadLine());
            {
                if (needHelp)
                {
                    Console.WriteLine("You need help");
                }
                
                if (!needHelp)
                {
                    Console.WriteLine("You do not need help");
                }
            }

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string posExp = Console.ReadLine();
            Console.WriteLine("Thank you for sharing positive experiences about " + posExp);

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("Thank you for sharing feedback about " + otherFeedback);

            Console.WriteLine("How many hours did you study today?");
            string totalHours = Console.ReadLine();
            int totalHrs = Convert.ToInt32(totalHours);
            Console.WriteLine("Good job completing " + totalHrs + " hours");

            Console.WriteLine("Thank you for your answers. An instructor will respond to you shortly.");
            Console.ReadLine();





        }
    }
}
