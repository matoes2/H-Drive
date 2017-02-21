using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value of the base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now enter the height");
            double h = Convert.ToDouble(Console.ReadLine());
            double areaOfATriangle = 0.5 * b * h;
            Console.WriteLine("The area of the triangle is: " + areaOfATriangle);
            Console.ReadKey();
        }
    }
}
