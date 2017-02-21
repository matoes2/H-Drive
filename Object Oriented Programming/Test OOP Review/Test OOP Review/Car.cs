using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OOP_Review
{
    class Car
    {
        private int Year;
        private int Speed;

        public Car()
        {
            Year = 2017;
            Speed = 260;
        }

        public void Accelerate()
        {
            Speed += 5;
        }
        public void Brake()
        {
            Speed -= 5;
        }
        public int GetYear()
        {
            return Year;
        }
        public int GetSpeed()
        {
            return Speed;
        }
    }
}
