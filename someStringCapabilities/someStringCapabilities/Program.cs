using System;
using System.Text;


namespace someStringCapabilities
{
    class Program
    {
        static void Main()
        {
            string name = "jan";
            Console.WriteLine("Hi there, my name is " + name.ToUpper() + ".\nI'm a Software Developer!");

            string firstLine = "Web developers design and create websites. They are responsible for the look of the site. ";
            string secondLine = "They are also responsible for the site’s technical aspects, such as its performance and capacity, which are measures of a website’s speed and how much traffic the site can handle. ";
            string thirdLine = "In addition, web developers may create content for the site.";
            StringBuilder allLines = new StringBuilder();
            allLines.Append("\n\t" + firstLine);
            allLines.Append(secondLine);
            allLines.Append(thirdLine);

            Console.WriteLine(allLines);
            Console.ReadLine();
        }
    }
}
