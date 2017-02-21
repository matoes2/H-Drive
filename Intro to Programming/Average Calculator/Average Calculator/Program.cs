using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Average Calculator!");
            Console.WriteLine(" Please enter the first number: ");
            string number1 = Console.ReadLine();
            int numbera1 = Convert.ToInt32(number1);
            Console.WriteLine("Great! Now please enter the second number: ");
            string number2 = Console.ReadLine();
            int numberb2 = Convert.ToInt32(number2);
            Console.WriteLine("Wow, you're a pro! Now enter the third number: ");
            string number3 = Console.ReadLine();
            int numberc3 = Convert.ToInt32(number3);
            Console.WriteLine("You're almost done! Now enter the last number: ");
            string number4 = Console.ReadLine();
            int numberd4 = Convert.ToInt32(number4);
            double average = ((numbera1 + numberb2 + numberc3 + numberd4) / 4.0);
            Console.WriteLine("Your average is: " + average.ToString("F2"));
            Console.ReadKey();


        }
    }
}
