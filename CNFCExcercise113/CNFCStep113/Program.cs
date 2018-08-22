using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFCStep
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            Method1 add = new Method1();
            //3. Call the method in the class, passing in two numbers.
            add.Addition(12, 21);
            //4. Call the method in the class, specifying the parameters by name.
            add.Addition(num1: 12, num2: 21);
        }
    }
}
