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
            int a = 3 + 4;
            int b = 5 - 2;
            int c = a + 4;
            int d = a - b;
            int sum = 1 + 2 - 3 + 4 - 5 + a - b + c - d;

            float totalCost = 22.54f;
            float tipPercent = 0.18f; // Remember, this is the same as 18%
            float tipAmount = totalCost * tipPercent;

            double moneyMadeFromGame = 100000; //Note that you DO NOT put commas in the number. C# won't know what to do with it
            double totalProgrammers = 4;
            double moneyPerPerson = moneyMadeFromGame / totalProgrammers; //We're rich!
                

            //The formula for the area of a circle is pi * r ^ 2
            float radius = 4;
            float pi = 3.1415926536f; // The 'f' at the end makes it treat as a float instead of a double.
            float area = pi * radius * radius;
            // Note how using '+' with a string "concatenates" the number on the end of the text.
            

            int totalApples = 23;
            int people = 7;
            int remainingApples = totalApples % people;

            //These are the unary '+' and unary '-' operators. They only work on the number right after them.
            int a = +3;
            int b = -44;
            //These are the binary '+' and binary '-' operators, also called addition and subtraction that work on two numbers around them.
            int a = 3 + 4;
            int b = 2 - 66;

            // Some simple code for the area of a trapezoid (http://en.wikipedia.org/wiki/Trapezoid)
            // Dont worry if you don't remember the equation.
            double side1 = 5.5;
            double side2 = 3.25;
            double height = 4.6;

            double areaOfTrapezoid = (side1 + side2) / 2 * height;

            double a = 3.2;
            double b = -4.3;
            double c = 42;
            double d = -91;
            double e = 4.343;

            double result = (((a + b) * (c - 4)) + d) * e;

            int a = 5;
            a = a + 1; // the variable a will have a value of 6 after running this line
            int a = 5;
            a += 3; // this is the same as a = a + 3;
            int b = 7
            b -= 3; //This is the same as b = b - 3; At this point b would be 4
            b *= 5; // This is the same as b = b * 5; At this point b would be 20.
            b /= 4; // This is the same as b = b / 4;  At this point b would be 5.
            b %= 2; // This is the same as b = b % 2;  At this point b would be 1.






        }
    }
}
