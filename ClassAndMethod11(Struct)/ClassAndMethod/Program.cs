using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create an object of data type Number and assign an amount to it.
            Number num = new Number();
            num.Abount = 12;

            //3. Print this amount to the console.
            Console.WriteLine(num.Abount);
            Console.ReadLine();
        }
    }
}
