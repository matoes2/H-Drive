using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    class Cat
    {
        private int age;
        private int livesRemaining;

        public Cat()
        {
            age = 0;
            livesRemaining = 0;
        }
        public void Birthday()
        {
            age += 1;
        }
        public void Death()
        {
            livesRemaining -= 1;
            age = 0;
        }
        public int GetAge()
        {
            return age;
        }
        public int GetLivesRemaining()
        {
            return livesRemaining;
        }
    }
}
