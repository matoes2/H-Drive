using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversionsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 123.3245;
            int myInt = 12;
            float myFloat = 19.6f;
            myDouble = myInt + .6;
            myInt = Convert.ToInt32(myFloat); // rounded to nearest
            myInt = Convert.ToInt32(myDouble);
            myInt = (int)myDouble;
            myDouble = myInt / 3;
            myDouble = 12.6;
            myFloat = 13.8f;
            myInt = Convert.ToInt32(myDouble + myFloat);
            myInt = Convert.ToInt32(myDouble) + Convert.ToInt32(myFloat);



            
           
            


        }
    }
}
