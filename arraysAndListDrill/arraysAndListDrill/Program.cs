using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select one index starting from 0 to 9.");
        byte num = Convert.ToByte(Console.ReadLine());
        string[] colors = { "White", "Black", "Red", "Yellow", "Pink", "Gray", "Blue", "Green", "Purple", "Orange"};
        string car = num > 9 ? "The index you chose doesn't exist!" : "\"" + colors[num] + "\"" + " is the color of your next car!";
        Console.WriteLine(car);
        Console.ReadLine();

        Console.WriteLine("Select one index starting from 0 to 9.");
        byte num2 = Convert.ToByte(Console.ReadLine());
        int[] year = { 2050, 2024, 2100, 2020, 2031, 2019, 2025, 2030, 2075, 2069 };
        string famous = num2 > 9 ? "The index you chose doesn't exist!" : "Your going to be famous by the year " + "\"" + year[num2] + "\".";
        Console.WriteLine(famous);
        Console.ReadLine();

        Console.WriteLine("Select one index starting from 0 to 6.");
        byte num3 = Convert.ToByte(Console.ReadLine());
        List<string> day = new List<string>();
        day.Add("Sunday");
        day.Add("Monday");
        day.Add("Tuesday");
        day.Add("Wednesday");
        day.Add("Thursday");
        day.Add("Friday");
        day.Add("Saturday");
        string fishing = num3 > 6 ? "The index you chose doesn't exist!" : "We're going fishing on " + day[num3] + "!";
        Console.WriteLine(fishing);
        Console.ReadLine();
    }
}
