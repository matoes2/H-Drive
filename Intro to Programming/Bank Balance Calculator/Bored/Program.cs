using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bored
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to money calculator.");
            Console.WriteLine("Please enter your bank balance: ");
            double bankBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter paycheck amount: ");
            double paycheckAmount = Convert.ToDouble(Console.ReadLine());
            double newBankBalance = bankBalance + paycheckAmount;
            Console.WriteLine("Your new bank balance is " + newBankBalance.ToString("C"));
            Console.ReadKey();

        }
    }
}
