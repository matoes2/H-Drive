using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*fix only 1 line in each of the 10 "mini programs" so that they print 
hello world the number of times specified by the comment.
if using c++ or Java switch Console.WriteLine to cout or System.out.println
respectively.
*/

            //1: prints hello world 10 times
            int i;
            i = 0;
            while (i <= 10)
            {
                Console.WriteLine("Hello World!");
                ++i;
            }
            Console.WriteLine("end problem 1");

            //2: print Hello World 10 times
            i = 1;
            while (i < 20)
            {
                Console.WriteLine("Hello World!");
                i = i + 2;
            }
            Console.WriteLine("end problem 2");

            //3: print Hello World 10 times
            i = 10;
            while (i > 0)
            {
                Console.WriteLine("Hello World!");
                i = i - 1;
            }
            Console.WriteLine("end problem 3");

            //4: print Hello World 10 times
            i = 0;
            while (i < 20)
            {
                Console.WriteLine("Hello World!");
                i = i + 2;
            }
            Console.WriteLine("end problem 4");

            //5: print Hello World 10 times
            i = 0;
            while (i < 10)
            {
                Console.WriteLine("Hello World!");
                ++i;
            }
            Console.WriteLine("end problem 5");

            //6: print Hello World 20 times
            i = 20;
            while (i >= 1)
            {
                Console.WriteLine("Hello World!");
                i = i - 1;
            }
            Console.WriteLine("end problem 6");

            //7: print Hello World 20 times
            i = 20;
            while (i > 0)
            {
                Console.WriteLine("Hello World!");
                --i;
            }
            Console.WriteLine("end problem 7");

            //8: print Hello World 10 times
            i = 0;
            while (i < 10)
            {

                Console.WriteLine("Hello World!");
                i = i + 1;
            }
            Console.WriteLine("end problem 8");

            //9: print Hello World 20 times
            i = 20;
            while (i > 0)
            {
                Console.WriteLine("Hello World!");
                i = i - 1;
            }
            Console.WriteLine("end problem 9");

            //10: print Hello World 20 times
            i = 1;
            while (i <= 20)
            {
                Console.WriteLine("Hello World!");
                i++;
            }
            Console.WriteLine("end problem 10");
        }
    }
}

