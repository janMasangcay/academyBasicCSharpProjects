using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);

            //2.Asks the user for a number.
            Console.Write("Enter a number: ");
            Double userInput = Convert.ToDouble(Console.ReadLine());

            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            Console.WriteLine(dateTime.AddHours(userInput));
            Console.ReadLine();
        }
    }
}