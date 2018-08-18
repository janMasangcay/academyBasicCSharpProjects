using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Instruction 1
            Console.WriteLine("Give me a number!");
            string multiply = Console.ReadLine();
            Console.WriteLine("Your number multiplied by 50: " + 50 * Convert.ToUInt32(multiply));
            Console.ReadLine();

            //Instruction 2
            Console.WriteLine("Give me another number!");
            string add = Console.ReadLine();
            Console.WriteLine("Your number plus 25: " + (Convert.ToUInt64(add) + 25));
            Console.ReadLine();

            //Instruction 3
            Console.WriteLine("Give me one more number! I know, don't even ask.");
            decimal total1 = 12.5m;
            string quotient = Console.ReadLine();
            Console.WriteLine("Your number divided by 12.5: " + (Convert.ToUInt32(quotient) / total1));
            Console.ReadLine();

            //Instruction 4
            Console.WriteLine("Give me a number and let's check if it's greater than 50!");
            string comparison = Console.ReadLine();
            bool trueOrFalse;
            if (Convert.ToUInt32(comparison) > 50)
            {
                trueOrFalse = true;
                Console.WriteLine(trueOrFalse);
            }
            else if (Convert.ToUInt32(comparison) < 50)
            {
                trueOrFalse = false;
                Console.WriteLine(trueOrFalse);
            }
            else
            {
                Console.WriteLine("It's equal!");
            }
            Console.ReadLine();

            //Instruction 5
            Console.WriteLine("Give me one last number!");
            string modulus = Console.ReadLine();
            Console.WriteLine("Your number % 7 is: " + (Convert.ToUInt32(modulus) % 7));
            Console.ReadLine();
        }
    }
}
