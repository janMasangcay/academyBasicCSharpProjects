using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantAndVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a const variable
            const string firstName = "Foo";

            //2.Create a variable using the keyword "var".
            var lastName = "Bar";

            //3.Chain two constructors together.
            Console.WriteLine($"{firstName} {lastName}");
            Console.ReadLine();
        }
    }
}
