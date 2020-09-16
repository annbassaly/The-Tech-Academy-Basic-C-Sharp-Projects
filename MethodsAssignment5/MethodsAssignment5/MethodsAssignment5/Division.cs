using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment5
{
    class Division
    {
     public void Divide( int num1, out int total)
        {
            total = num1 / 2;
            
        }
        public void Divide(int num1, out int total, int num2)
        {
            total = num1 / 2 + num2;
        }

    }
}

