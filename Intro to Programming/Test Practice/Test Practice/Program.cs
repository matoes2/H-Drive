using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 2;
            string myString = "Rofl Copter";
            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            myInt += 5;
            double anotherVar = myInt * 2;
            double aVar = anotherVar / 10;
            Console.WriteLine(aVar);
            string stringVar = Convert.ToString(myInt);
            stringVar = myString + 22;
            Console.WriteLine("stringVar holds: " + stringVar);
            Console.WriteLine("Input a number: ");
            int var6 = Convert.ToInt32(Console.ReadLine());
            var6 += 12;
            Console.WriteLine(var6);
            Console.ReadKey();
        }
    }
}
