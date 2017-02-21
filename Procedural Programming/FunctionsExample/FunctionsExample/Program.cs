
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            int number = GetInput();
            Console.WriteLine("Enter another number");
            int number2 = GetInput();
            int sum = number + number2;
            Console.WriteLine("Your number is: " + sum);
            Console.ReadKey();
        }

        static int GetInput()
        {
            int num1;
            while (true)
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    return num1;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("That was not a number, please enter a number");

                }
            }
        }
    }
}
