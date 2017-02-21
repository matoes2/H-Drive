using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pretest_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 6;
            string var2 = "Frank";
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            var1 += 5;
            int var3 = var1 * 2;
            float var4 = var1 / 2f;
            Console.WriteLine(var4);
            string var5 = Convert.ToString(var3);
            var2 = var2 + var5;
            Console.WriteLine("var 2 holds: " + var2);
            Console.WriteLine("Please input a number: ");
            int var6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(var6);




        }
    }
}
