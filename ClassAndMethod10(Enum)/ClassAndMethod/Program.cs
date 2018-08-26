using System;
using System.Collections.Generic;

namespace ClassAndMethod
{
    class Program
    {
        //1.Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            sunday, monday, tuesday, wednesday, thursday, friday, saturday
        }
        static void Main(string[] args)
        {
            //4. Wrap the above statement in a try/catch block and have it print 
            //"Please enter an actual day of the week." to the console if an error occurs.
            try
            {
                //2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Enter current day:");
                string userInput = Console.ReadLine();
                                
                //3. Assign the value to a variable of that enum data type you just created.
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput.ToLower());
                
                for (int i = 0; i < 7; i++)
                {
                    if (day == (DaysOfTheWeek)i)
                    {
                        Console.WriteLine($"Yes! Today is {day}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
