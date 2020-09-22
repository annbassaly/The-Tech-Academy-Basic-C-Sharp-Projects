using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractAssignmentpg237
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();

        //public virtual void ListPlayers()
        //{
        //    foreach (string player in Players)
        //    {
        //        Console.WriteLine(player);
        //    }

        //}
    }
}

