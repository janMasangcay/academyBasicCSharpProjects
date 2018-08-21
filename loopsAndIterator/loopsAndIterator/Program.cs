using System;
using System.Collections.Generic;

namespace loopsAndIterator
{
    class Program
    {
        static void Main()
        {
            ////1.Create a one-dimensional Array of strings.Ask the user to input some text.Create a loop that goes 
            ////through each string in the Array, adding the user’s text to the string.Then create a loop that prints 
            ////off each string in the Array on a separate line.

            //string[] arr = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "" };
            //Console.WriteLine("Add some text:");
            //string userInput = Console.ReadLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[arr.Length - 1] = userInput;
            //    Console.WriteLine(arr[i]);
            //}


            ////2.Create an infinite loop.

            //bool stopLoop = false;
            //while (!stopLoop)
            //{
            //    Console.WriteLine("Hello World");
            //}


            ////3.Fix the infinite loop so it will execute.

            //bool stopLoop = false;
            //while (!stopLoop)
            //{
            //    Console.WriteLine("Hello World");
            //    stopLoop = true;
            //}


            ////5.Create a loop where the comparison used to determine whether to continue iterating the loop 
            ////is a “<=” operator.

            //for (int y = 0; y <= arr.Length - 1; y++)
            //{
            //    Console.WriteLine(arr[y]);
            //}


            ////6.Create a List of strings where each item in the list is unique.Ask the user to select text to search 
            ////for in the List.Create a loop that iterates through the loop and then displays the index of the array 
            ////that contains matching text on the screen.
            ////7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            ////8.Add code to that above loop that stops it from executing once a match has been found.
            ////9.Create a List of strings that has at least two identical strings in the List. Ask the user to select 
            ////  text to search for in the List.Create a loop that iterates through the loop and then displays the indices
            ////  of the array that contain matching text on the screen.
            ////10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> randomText = new List<string>() { "one", "two", "three", "four", "five", "six", "sexen", "eight", "nine", "ten",
            //                                              "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday",
            //                                              "white", "black", "gray", "red", "yellow", "hello", "blue", "green", "orange", "gold",
            //                                              "loop", "array", "string", "integer", "bool", "null", "decimal", "list", "length",
            //                                              "hello", "world", "hi", "taco", "fries", "burger", "burrito", "apple", "coffee",
            //                                              "fish", "steak", "rice", "salad", "salmon", "burrito" };
            //Console.WriteLine("Select a text in the list:");
            //string userInput1 = Console.ReadLine().ToLower();
            //bool matched = false;
            //while (!matched)
            //{
            //    for (int j = 0; j < randomText.Count; j++)
            //    {
            //        if (randomText[j] == userInput1)
            //        {
            //            Console.WriteLine(j);
            //            matched = true;
            //        }
            //    }
            //    if (!matched)
            //    {
            //        Console.WriteLine("No match found! Please try again:");
            //        userInput1 = Console.ReadLine().ToLower();
            //    }
            //}


            ////11.Create a List of strings that has at least two identical strings in the List. Create a
            ////foreach loop that evaluates each item in the list, and displays a message showing the string 
            ////and whether or not it has already appeared in the list.

            //List<string> randomText1 = new List<string>() { "one", "two", "three", "four", "five", "six", "sexen", "eight", "nine", "ten",
            //                                               "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday",
            //                                               "white", "black", "gray", "red", "yellow", "hello", "blue", "green", "orange", "gold",
            //                                               "loop", "array", "string", "integer", "bool", "null", "decimal", "list", "length",
            //                                               "hello", "world", "hi", "taco", "fries", "burger", "burrito", "apple", "coffee",
            //                                               "fish", "steak", "rice", "salad", "salmon", "burrito" };
            //List<string> randomText2 = new List<string>();
            //foreach (string text in randomText1)
            //{
            //    for (int z = 0; z < randomText2.Count; z++)
            //    {
            //        if (text == randomText2[z])
            //        {
            //            Console.WriteLine("This word already appeared:");
            //        }
            //    }
            //    randomText2.Add(text);
            //    Console.WriteLine(text);
            //}

            Console.ReadLine();
        }
    }
}
