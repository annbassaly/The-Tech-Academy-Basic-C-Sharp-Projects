using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Hi, my name is Ann Marie. ";
            //string fine = "How are you doing? ";
            //string weather = "It is a windy day today.";
            //string sentence = string.Concat(name, fine, weather);
            //name = name.ToUpper();

            //Console.WriteLine(sentence);
            ////Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
