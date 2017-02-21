using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int j;
            bool x = false;

            for (int i = 2; i <= number; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        x = true;
                    }
                }
                if (x == false)
                {
                    Console.WriteLine("The prime numbers are: " + j);
                }
                else
                {
                    x = false;
                }
            }
            Console.ReadKey();
        }
    }
}
