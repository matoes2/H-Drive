using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a greeting message.
            Console.WriteLine("Welcome to Cylinder");

            // Read in the cylinder's radius from the user
            Console.Write("Enter the cylinder's radius: ");
            string radiusAsAString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsAString);

            // Read in the cylinder's height from the user
            Console.Write("Enter the cylinder's height: ");
            string heightAsAString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsAString);

            double pi = 3.1415926536;

            //These are two standard formulas for volume and surface area of a cylinder.
            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            //Now we output the results
            Console.WriteLine("The cylinder's volume is: " + volume + " cubic units.");
            Console.WriteLine("The cylinder's surface area is: " + surfaceArea + " square units.");

            // Wait for user to respond before closing
            Console.ReadKey();
        }
    }
}
