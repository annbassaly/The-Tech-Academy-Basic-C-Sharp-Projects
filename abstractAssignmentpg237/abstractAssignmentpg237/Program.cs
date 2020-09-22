using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignmentpg237
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.firstName = "Sample ";
            person.lastName = "Student";
            person.SayName();    
            Console.WriteLine(person.firstName + person.lastName);
            Console.ReadLine();
        }
    }
}
