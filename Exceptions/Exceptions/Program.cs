using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Exceptions must be handled using "try .. catch".
            try
            {
                //1.Ask the user for his age.
                Console.WriteLine("How old are you?");
                var age = Convert.ToInt32(Console.ReadLine());

                //4.Display appropriate error messages if user enters zero or negative numbers.
                if (age < 1)
                {
                    Console.WriteLine("Cannot enter 0 or negative.");
                    return;
                }

                //2.Display the year user born.
                var currentYear = DateTime.Now;
                Console.WriteLine($"Birth year: {currentYear.Year - age}");

            }
            //5.Display a general message if exception caused by anything else.
            catch (Exception)
            {
                Console.WriteLine("Error! Please call for assistance.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
