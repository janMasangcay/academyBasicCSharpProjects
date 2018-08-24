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
            //3. Instantiate an Employee object with type "string" as its generic parameter.
            //Assign a list of strings as the property value of Things.
            Employee<string> cars = new Employee<string>();
            cars.Things = new List<string>();
            cars.Things.Add("Jeep Rubicon");
            cars.Things.Add("BMW M3");
            cars.Things.Add("Honda TypeR");
            cars.Things.Add("Ford RS");
            cars.Things.Add("Nissan GTR");
            cars.Things.Add("Toyota Supra");
            cars.Things.Add("Mazdaspeed3");
            cars.Things.Add("Subaru STI");
            cars.Things.Add("Mitsubishi EvoX");
            //4. Instantiate an Employee object with type "int" as its generic parameter.
            //Assign a list of integers as the property value of Things.
            Employee<int> horsePower = new Employee<int>();
            horsePower.Things = new List<int>();
            horsePower.Things.Add(285);
            horsePower.Things.Add(445);
            horsePower.Things.Add(306);
            horsePower.Things.Add(350);
            horsePower.Things.Add(595);
            horsePower.Things.Add(320);
            horsePower.Things.Add(265);
            horsePower.Things.Add(305);
            horsePower.Things.Add(303);
            //5. Create a loop that prints all of the Things to the Console.
            for (int i = 0; i < cars.Things.Count; i++)
            {
                Console.WriteLine(cars.Things[i]);
                Console.WriteLine($"Horsepower: {horsePower.Things[i]} \n");
            }
            Console.ReadLine();
        }
    }
}
