using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethod
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        //2. Have your Employee class from the previous drill inherit that interface and implement the Quit() 
        //method in any way you choose.
        public void Quit()
        {
            Console.WriteLine("Resinged employees:");
            SayName();
            Console.ReadLine();
        }
    }
}
