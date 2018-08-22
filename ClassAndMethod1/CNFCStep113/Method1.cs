using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFCStep
{
    class Method1
    {
        //1.Create a class. In that class, create a void method that takes two 
        //integers as parameters. Have the method do a math operation on the first 
        //integer and display the second integer to the screen.
        public void Addition(int num1, int num2)
        {
            num1 = num1 + num2;
            Console.WriteLine(num2);
            Console.ReadLine();
        }
    }
}
