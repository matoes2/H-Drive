using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int a = 1;
            while(a <= 100)
            {
                Console.WriteLine(a);
                ++a;
            }
            //2
            a = 0;
            while(a <= 100)
            {
                Console.WriteLine(a);
                a += 2;
            }
            //3
            a = 1;
            while(a <= 100)
            {
                Console.WriteLine(a);
                a += 2;
            }
            Console.WriteLine("100");
            //4
            a = 5;
            while(a <= 80)
            {
                Console.WriteLine(a);
                ++a;
            }
            //5
            a = 50;
            while(a >= 5)
            {
                Console.WriteLine(a);
                --a;
            }
            //6
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a larger number number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            while(num1 <= num2 && num2 >= num1)
            {
                Console.WriteLine(num1);
                ++num1;
            }
            //7
            int b = 1;
            a = 1;
            while(a <= 10 && b <= 10)
            {
                Console.WriteLine("I counted to 10, " + b + " times");
                ++a;
                ++b;
            }
            //8
            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a larger number number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            while (num1 != num2)
            {
                if (num1 % 3 == 0)
                {
                    Console.WriteLine(num1);
                    ++num1;
                }
                else
                {
                    ++num1;
                }
            }
            Console.ReadKey();
        }
    }
}
