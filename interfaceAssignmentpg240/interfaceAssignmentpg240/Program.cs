using System;

namespace interfaceAssignmentpg240
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            {
                person.firstName = "Sample";
                person.lastName = "Student";
            };
            person.SayName();
            IQuittable quittable = new Employee();
            quittable.Quit(person);
            Console.ReadLine();

        }

    }
}
