using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        ////1.Create a list of integers. Ask the user for a number to divide each number in the list by.
        ////  Write a loop that takes each integer in the list, divides it by the number the user entered, 
        ////  and displays the result to the screen.

        //List<double> numbers = new List<double>() { 32, 45, 12, 93, 54, 62, 123, 765, 452 };
        //Console.WriteLine("Enter a number:");
        //int userNumber = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    Console.WriteLine(numbers[i] / userNumber);
        //}

        ////2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.
        ////4.Run that code, entering in a string as the number to divide by.Note any error messages you get.
        ////Code error: System.FormatException

        ////3.Run that code, entering in zero as the number to divide by.Note any error messages you get.
        ////Code error: System.DivideByZeroException

        ////5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program 
        ////  display a message to the display to let you know the program has emerged from the try/catch block 
        ////  and continued on with program execution.In the catch block, display the error message to the screen.
        ////  Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error 
        ////  messages display on the screen, and that the code after the try/catch block gets executed.

        //try
        //{
        //    List<int> numbers = new List<int>() { 32, 45, 12, 93, 54, 62, 123, 765, 452 };
        //    Console.WriteLine("Enter a number:");
        //    int userNumber = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        Console.WriteLine(numbers[i] / userNumber);
        //    }
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    return;
        //}
        //catch (FormatException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //    return;
        //}
        //finally
        //{
        //    Console.WriteLine("End of the program.");
        //    Console.ReadLine();
        //}
    }
}

