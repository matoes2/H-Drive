using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.A
              2.A
              3.C
              4.B
              5.A
              6.A
              7.A
              8.A
              9.A
              10.D
              11.A
              12.B
              13.A
              14.A
              15.C
              16.A
              17.A
              18.B
            */
            Car car = new Car();
            car.Accelerate();
            Console.WriteLine(car.GetYear());
        }
    }
}
