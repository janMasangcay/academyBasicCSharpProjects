using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Resinged employees:");
            SayName();
            Console.ReadLine();
        }

        //Overload the "==" operator so it checks if two Employee objects are equal by comparing 
        //their Id property.
        public static bool operator== (Employee person1, Employee person2)
        {
            if (person1.Id == person2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!= (Employee person1, Employee person2)
        {
            if (person1.Id != person2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
