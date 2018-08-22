using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod3
{
    public class Method
    {
        //1.Create a class. In that class, create a method that takes two integers as parameters.
        //Make one of them optional.Have the method do a math operation and return a integer result.
        public int Calc(int Num1, int Num2 = 0)
        {
            return Num1 = Num1 * Num2;
        }
    }
}
