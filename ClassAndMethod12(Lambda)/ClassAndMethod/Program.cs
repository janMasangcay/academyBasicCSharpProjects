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
            //1.In the Main() method, create a list of at least 10 employees.Each employee should have a 
            //first and last name, as well as an Id.At least two employees should have the first name "Joe".
            Employee person1 = new Employee() { FirstName = "Joe", LastName = "Button", ID = 01 };
            Employee person2 = new Employee() { FirstName = "Mae", LastName = "List", ID = 02 };
            Employee person3 = new Employee() { FirstName = "Dom", LastName = "Argument", ID = 03 };
            Employee person4 = new Employee() { FirstName = "Kat", LastName = "Parameter", ID = 04 };
            Employee person5 = new Employee() { FirstName = "Joe", LastName = "Main", ID = 05 };
            Employee person6 = new Employee() { FirstName = "Rick", LastName = "Static", ID = 06 };
            Employee person7 = new Employee() { FirstName = "John", LastName = "Void", ID = 07 };
            Employee person8 = new Employee() { FirstName = "Sam", LastName = "String", ID = 08 };
            Employee person9 = new Employee() { FirstName = "Lay", LastName = "Array", ID = 09 };
            Employee person10 = new Employee() { FirstName = "Vic", LastName = "Public", ID = 10 };
            List<Employee> employees = new List<Employee>() { person1, person2, person3, person4, person5,
                                                          person6, person7, person8, person8, person10};

            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Person> sameName = new List<Person>();
            foreach (Person person in employees)
            {
                if (person.FirstName == "Joe")
                {
                    sameName.Add(person);
                }
            }
            
            //3.Do the same thing again, but this time with a lambda expression.
            List<Employee> sameName2 = employees.Where(x => x.FirstName == "Joe").ToList();
            sameName2.ForEach(x => x.SayName());
            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> idGreaterThanFive = employees.Where(x => x.ID > 5).ToList();
            Console.ReadLine();
        }
    }
}
