using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodCNFC
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Write the number you want to use in this operation:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            //3. Call each method in turn, passing the user input to the method.Display the returned integer
            //to the screen.
            Console.WriteLine(
                "Your number added to itself: " + (MathOperations.Addition(userNum)) +
                "\nYour number subtracted to itself: " + (MathOperations.Subtraction(userNum)) +
                "\nYour number multiplied to itself: " + (MathOperations.Multiplication(userNum))
                );
            Console.ReadLine();
        }
    }
}
