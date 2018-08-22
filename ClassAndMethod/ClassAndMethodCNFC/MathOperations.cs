using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodCNFC
{
    class MathOperations
    {
        //1.Create a class. In that class, create three methods, each of which will take one integer 
        //parameter in and return an integer.The methods should do some math operation on the received
        //parameter. Put this class in a separate.cs file in the application.
        static public int Addition (int num) 
        {
            return num = num + num;
        }
        static public int Subtraction (int num)
        {
            return num = num - num;
        }
        static public int Multiplication (int num)
        {
            return num = num * num;
        }
    }
}
