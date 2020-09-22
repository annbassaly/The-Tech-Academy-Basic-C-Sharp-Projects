using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceAssignmentpg240
{
    public class Employee : Person, IQuittable
    {
        public override string SayName()
        {
            return base.SayName();
        }
        public void Quit(Employee employee)
        {
            Console.WriteLine(employee.SayName() + " " + "has quit");
        }
    }
}
