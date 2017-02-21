using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your test score: ");
            int testScore = Convert.ToInt32(Console.ReadLine());
            if (testScore == 100)
            {
                Console.WriteLine("Omg. You're so smart!!. Awesome job!!!!");
            }
            else if (testScore >= 93)
            {
                Console.WriteLine("You got an A!");
            }
            else if (testScore >= 90)
            {
                Console.WriteLine("You got an A-.");
            }
            else if (testScore >= 87)
            {
                Console.WriteLine("You got a B+");
            }
            else if (testScore >= 83)
            {
                Console.WriteLine("You got a B");
            }
            else if (testScore >= 80)
            {
                Console.WriteLine("You got a B-");
            }
            else if (testScore >= 77)
            {
                Console.WriteLine("You got a C+");
            }
            else if (testScore >= 73)
            {
                Console.WriteLine("You got a C");
            }
            else if (testScore >= 70)
            {
                Console.WriteLine("You got a C-");
            }
            else if (testScore >= 67)
            {
                Console.WriteLine("You got a D+");
            }
            else if (testScore >= 63)
            {
                Console.WriteLine("You got a D");
            }
            else if (testScore >= 60)
            {
                Console.WriteLine("You got a D-");
            }
            else if (testScore < 60)
            {
                Console.WriteLine("You got an E. You suck. Get good m8.");
            }
            Console.ReadKey();


        }
    }
}
