using System;

namespace basicApprovalProgram
{
    class Program
    {
        static void Main()
        {
            //Form
            Console.WriteLine("Approval Form");
            Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();

            //Decision
            Console.WriteLine(Convert.ToInt16(age) > 15 && dui == "false" && Convert.ToInt16(ticket) <= 3);
            Console.ReadLine();
        }
    }
}
