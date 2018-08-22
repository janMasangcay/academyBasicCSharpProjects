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
            try
            {
                //2. In the Main() method, instantiate that class.
                Method1 divide = new Method1();

                //3. Have the user enter a number.Call the method on that number.
                //Display the output to the screen. It should be the entered number, divided by two.
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                divide.Calc(num);

                divide.Calc(out string message);

                Method2.Intro();
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
