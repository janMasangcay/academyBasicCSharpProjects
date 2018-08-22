using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //2. In the Main() method of the console app, instantiate the class.
                Method multiply = new Method();

                //3. Ask the user to input two numbers, one at a time.Let them know they need not enter 
                //anything for the second number.
                //4. Call the method in the class, passing in the one or two numbers entered.

                Console.WriteLine("Enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = 0;
                Console.WriteLine($"Optional. Would you like to add another number?\nPlease type in \"Yes\" or \"No\":");
                string yesOrNo = Console.ReadLine().ToLower();
                if (yesOrNo == "yes")
                {
                    Console.WriteLine("Please enter another number:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(multiply.Calc(Num1: num1, Num2: num2));
                }
                else
                {
                    Console.WriteLine(multiply.Calc(Num1: num1));
                }

                //5. Try various combinations of numbers on the code, including having no second number.

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
