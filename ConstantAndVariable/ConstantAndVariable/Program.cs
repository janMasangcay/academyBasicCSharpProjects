using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantAndVariable
{
    class Program
    {
        //3.Chain two constructors together.
        public Program(string firstName) 
            : this(firstName, "")
        {
        }
        public Program(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
        public string FirstName;
        public string LastName;

        public static void Main()
        {
            ////1.Create a const variable
            const string firstName = "Foo";

            //2.Create a variable using the keyword "var".
            var lastName = "Bar";

            Program name = new Program(firstName, lastName);
            Console.WriteLine($"{name.FirstName} {name.LastName}");
            Console.ReadLine();
        } 
    }
}
