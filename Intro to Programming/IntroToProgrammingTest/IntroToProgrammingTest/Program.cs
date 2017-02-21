using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgrammingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.C
               2.D
               3.A
               4.B
               5.B
               6.Making room for variables that are being stored.
               7.Initializing is assigning a value to a variable for the first time, declaring is setting the data type and the name for a variable.

               float myDecimal = 15.1f;
               int myInteger = 10;
               string myString = "its Testing Time!;
               string myOtherString = "Yay Tests!";
               bool myBool = True;
               string myWord = Convert.ToString(myDecimal);
               myDecimal = Convert.ToSingle(myBool);
               int myOtherInt;
               myOtherInt = myInteger / 2; //initialize myOtherInt to half of myInteger
               myOtherInt += 1; //add 1 to myOtherInt
               myInteger += 5; //add five to myInteger
             */

            int myInt = 4;
            string myString = "Here Take This";
            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            myInt += 4;
            double anotherVar = myInt * 2;
            double aVar = anotherVar / 10;
            Console.WriteLine(aVar);
            string stringVar = Convert.ToString(myInt);
            stringVar = myString + stringVar + stringVar;
            Console.WriteLine("stringVar holds: " + stringVar);
            Console.WriteLine("Input a number: ");
            int var6 = Convert.ToInt32(Console.ReadLine());
            var6 += 15;
            Console.WriteLine(var6);
            Console.ReadKey();
        }
    }
}
