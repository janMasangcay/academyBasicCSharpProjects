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
            Employee person1 = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1
            };
            Employee person2 = new Employee()
            {
                firstName = "Beta",
                lastName = "Student",
                Id = 2
            };

            Console.WriteLine(person1 == person2);
            Console.ReadLine();

            //IQuittable Quit = new Employee() { firstName = "Sample", lastName = "Employee" };
            //Quit.Quit();
        }
    }
}
