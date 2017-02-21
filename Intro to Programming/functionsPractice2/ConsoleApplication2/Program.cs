using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Remember if you were to use these functions in C# or Java to include the static keyword infront of the return type
            //Ex: static int MyFunction(int someNumber){}


            1.) What is the value of var1 at the end of this code ? 12
            

            int MyFunction2(int someNumber){
                return someNumber + 5;
            }
            int MyFunction(int myNumber){
                myNumber = myNumber + 2;
                return myFunction2(myNumber);
            }
            int Main(){
                int var1 = 10;
                int var1 = MyFunction(var1);
                return 0;
            }


            2.) What is the value of var1 at the end of running the code in the main function ? 24
            int MyFunction(double myNumber){
                return Convert.ToInt32(myNumber) + 12;
            }
            int Main(){
                int var1 = 10;
                var1 = MyFunction(12.0);
                return 0;
            }


            3.) What is the value of var1 at the end of running the code in the main function ? 10
            int MyFunction(int myNumber){
                myNumber = myNumber + 10;
                return 12;
            }
            int Main(){
                int var1 = 10;
                int var2 = MyFunction(var1);
                return 0;
            }
            a. 10


4.) What is the value of var1 at the end of running the code in the main function ? 10
int MyFunction(ref int myNumber){
                myNumber = myNumber + 10;
                return 12;
            }
            int Main(){
                int var1 = 10;
                int var2 = MyFunction(ref var1);
                return 0;
            }


            5.) What is the value of var1 at the end of running the code in the main function ? 12
            int MyFunction(int myNumber){
                myNumber = myNumber + 10;
                return 12;
            }
            int Main(){
                int var1 = 10;
                int var1 = MyFunction(var1);
                return 0;
            }


            6.) look at the following function definition and answer the following questions

void MyFunction(int a, int b, int c):
	int d = (a + c) / b

    print(d)

A) write a statement that calls this function passing 2 in for a, 4 in for b, and 6 in for c.
    MyFunction(2, 4, 6);
B) What value will be displayed when the function executes using the values from part
    1
 */        
            average("Alex", 100, 100, 100);
            Console.ReadKey();
         
            nums(5, 7);

        }
        static void average(string name, int test1, int test2, int test3)
        {
            int testAverage = (test1 + test2 + test3) / 3;
            Console.WriteLine("Your name is: " + name + "\nYour test score average is: " + testAverage);
        }
        
        static void nums(int num1, int num2)
        {
            if(num2 < num1)
            {
                int numTemp;
                numTemp = num1;
                num1 = num2;
                num2 = numTemp;
               
                Console.WriteLine("Num1 = " + num1);
                Console.WriteLine("Num2 = " + num2);

            }
            else if (num2 >= num1)
            {
                Console.WriteLine("Nothing...");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
        }
    }
}
