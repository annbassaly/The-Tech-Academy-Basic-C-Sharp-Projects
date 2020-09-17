using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Person
    {
        public List<string> Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            foreach (string name in Name)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
