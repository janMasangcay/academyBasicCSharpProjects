using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ask a user for a number.
            Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();

            //2.Log that number to a text file
            File.WriteAllText(@"C:\Users\jcmas\Desktop\academyProjects\academyProjects\visualStudiosFile\academyBasicCSharpProjects\FileIO\NumberLogs.txt", userInput);

            //3.Print the text file back to the user.
            userInput = File.ReadAllText(@"C:\Users\jcmas\Desktop\academyProjects\academyProjects\visualStudiosFile\academyBasicCSharpProjects\FileIO\NumberLogs.txt");
            Console.WriteLine(userInput);
            Console.ReadLine();
        }
    }
}
