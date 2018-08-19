using System;

namespace whileAndDoWhile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type Erik's lastname to quit!");
            string name = Console.ReadLine();
            string myName = "gross";

            while (myName != name)
            {
                Console.WriteLine("That is not his lastname.");
                name = Console.ReadLine();
            }
            Console.WriteLine("Enter Jack's LastName to quit!");
            string lastName = Console.ReadLine();
            string myLastName = "stanley";

            do
            {
                Console.WriteLine("That is not his LastName.");
                lastName = Console.ReadLine();
            }
            while (myLastName != lastName);
            Console.WriteLine("Excellent! You did your research.");
            Console.ReadLine();
        }
    }
}
