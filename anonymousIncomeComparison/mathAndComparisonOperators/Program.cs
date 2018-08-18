using System;

namespace mathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            //Person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            string person1Rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string person1WorkHours = Console.ReadLine();
            double person1Total = Convert.ToDouble(person1Rate) * Convert.ToDouble(person1WorkHours) * 52;
            Console.ReadLine();

            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            string person2Rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string person2WorkHours = Console.ReadLine();
            double person2Total = Convert.ToDouble(person2Rate) * Convert.ToDouble(person2WorkHours) * 52;
            Console.ReadLine();

            //Annual salary
            Console.WriteLine("Annual salary of Person 1: " + person1Total);
            Console.WriteLine("Annual salary of Person 2: " + person2Total);
            Console.ReadLine();

            //Compare Person 1 to Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            if (person1Total > person2Total)
            {
                Console.WriteLine(true);
            }
            else if (person1Total < person2Total)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine("They make the same!");
            }
            Console.ReadLine();
        }
    }
}
