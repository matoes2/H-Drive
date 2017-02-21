using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first test score: ");
            double testScore1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second test score: ");
            double testScore2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your third test score: ");
            double testScore3 = Convert.ToDouble(Console.ReadLine());
            double testAverage = (testScore1 + testScore2 + testScore3) / 3.0;
            Console.WriteLine("Your test score average is: " + testAverage.ToString("F2"));
            if (testAverage >= 95.0)
            {
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Better luck next time♥");
            }
            Console.ReadKey();

        }
    }
}
