using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 1;
            Console.WriteLine(score);
            // This declares and assigns these variables
            // all in one step.
            short levelNumber = 3;
            int score = 0;

            // This declares a variable, and assigns it
            // at a later point in time.
            long aBigNumber;
            aBigNumber = -17;

            // Here is a byte, which contains any value
            // between 0 and 255 inclusive.
            byte aSingleByte = 55;

            // Here's the unsigned stuff.
            ushort thisHoldsPositivesOnly = 45;
            uint sameHere = 503494;
            ulong sameHereButBigger = 449494033;

            // The text-based variable types
            char myFavoriteLetter = 'c'; // It's my favorite, because it's for cookie.
            string aMessage = "You've received a new message at your private terminal.";

            // The Boolean type.
            bool stillWorking = true;
            stillWorking = false;
        }
    }
}
