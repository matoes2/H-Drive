using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndoOfIntroToProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 9;
            double var2 = 4.7;
            string var3 = "74";
            string var4 = "U";
            double var5 = var1 + var2;
            Console.WriteLine(var5);
            int myInt = Convert.ToInt32(var5 - .5);
            Console.WriteLine(myInt);
            var2 -= 1;
            myInt *= 10;
            myInt += 3;
            Console.WriteLine(myInt);
            var2 -= 1;
            var2 = Convert.ToInt32(var2 - .7);
            string var6 = var2 + (myInt + var3 + var4);
            Console.WriteLine(var6);
            Console.WriteLine("Please enter your name: ");
            string valueOfName = Console.ReadLine();
            Console.WriteLine("Hi " + valueOfName + " I am " + var6);
            Console.ReadKey();

            

            





        }
    }
}
