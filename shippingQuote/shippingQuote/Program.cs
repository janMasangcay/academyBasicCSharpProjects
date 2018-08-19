using System;

namespace shippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight: ");
            double packageWeight = Convert.ToDouble(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                double packageWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                double packageHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                double packageLength = Convert.ToDouble(Console.ReadLine());
                double total = packageWidth + packageHeight + packageLength;
                string result = total > 50 ? "Package too big to be shipped via Package Express." :
                                "Your estimated total for shipping this package is: $" + (total * packageWeight / 100) + "\nThank You.";
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
