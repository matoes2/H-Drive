using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int pistol = 70;
        static int stunGun = 40;
        static int laserDagger = 100;
        static void Main(string[] args)
        {
            string choice1 = Console.ReadLine();
            if (choice1 == "y")
            {
                Console.WriteLine("Ok, what we're doing is top secret.");
                Console.WriteLine("We are hunting the most dangerous criminals on the planet");
                Console.WriteLine("We have given you a couple of weapon choices and armor choices. Pick one of each");
                Console.WriteLine("Choose your weapon:\nPistol\nStun gun\nLaser Dagger");
                string weaponChoice = Console.ReadLine();
                if (weaponChoice == ("Pistol"))
                {
                    Console.WriteLine("You chose the pistol. It's damage is: " + pistol);
                }
                else if (weaponChoice == "Stun Gun")
                {
                    Console.WriteLine("You chose the stun gun. It's damage is: " + stunGun);
                }
                else if (weaponChoice == ("Laser Dagger"))
                {
                    Console.WriteLine("You chose the Laser Dagger. It's damage is: " + laserDagger);
                }

            }
            Console.ReadKey();
        }
    }
}
