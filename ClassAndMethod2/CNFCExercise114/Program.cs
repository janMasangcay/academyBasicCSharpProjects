using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFCExercise114
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class and call the 
            //one method, passing in an integer, such as 12. Then display the result to the screen.
            int add = MethodExercise.Calculate(12);
            Console.WriteLine("Arg added to itself: {0}", add);
            Console.ReadLine();

            //4. In the Main() method of the console app, instantiate the class and call the second 
            //method, passing in a decimal. Display the result to the screen.
            int divide = MethodExercise.Calculate(12.12m);
            Console.WriteLine("Arg divide by 2 is: {0}", divide);
            Console.ReadLine();

            //6. In the Main() method of the console app, instantiate the class and call the third 
            //method, passing in a string that equates to an integer.Display the result to the screen.
            int multiply = MethodExercise.Calculate("24");
            Console.WriteLine("Arg multiplied to itself: {0}", multiply);
            Console.ReadLine();
        }
    }
}
