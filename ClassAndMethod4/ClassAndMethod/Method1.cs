using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class Method1
    {
        //1.Create a class. In that class, create a void method that outputs an integer.
        //Have the method divide the data passed to it by 2.
        public void Calc(int num)
        {
            Console.WriteLine(num = num / 2);
            Console.ReadLine();
        }

        //4. Create a method with output parameters.
        //5. Overload a method.
        public void Calc(out string message)
        {
            Console.WriteLine(message = "Hello World!");
            Console.ReadLine();
        }
    }
}
