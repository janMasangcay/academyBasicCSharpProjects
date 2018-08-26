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
            Person person1 = new Person() { FirstName = "Joe", LastName = "Button", ID = 01 };
            Person person2 = new Person() { FirstName = "Mae", LastName = "List", ID = 02 };
            Person person3 = new Person() { FirstName = "Dom", LastName = "Argument", ID = 03 };
            Person person4 = new Person() { FirstName = "Kat", LastName = "Parameter", ID = 04 };
            Person person5 = new Person() { FirstName = "Joe", LastName = "Main", ID = 05 };
            Person person6 = new Person() { FirstName = "Rick", LastName = "Static", ID = 06 };
            Person person7 = new Person() { FirstName = "John", LastName = "Void", ID = 07 };
            Person person8 = new Person() { FirstName = "Sam", LastName = "String", ID = 08 };
            Person person9 = new Person() { FirstName = "Lay", LastName = "Array", ID = 09 };
            Person person10 = new Person() { FirstName = "Vic", LastName = "Public", ID = 10 };
            List<Person> employees = new List<Person>() { person1, person2, person3, person4, person5,
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
            List<Person> sameName2 = employees.Where(x => x.FirstName == "Joe").ToList();

            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Person> idGreaterThanFive = employees.Where(x => x.ID > 5).ToList();
        }
    }
}
