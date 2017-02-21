using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int weaponStrength = 50;
            int armor = 100;
            Console.WriteLine("Welcome to Cave Hunter, your goal is to get to the royal city Darmius\nwithout dying. Are you ready?");
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " which cave would you like to enter? \nThe cave of the Frost Giants.(FG) \nThe Webspinner's cave.(W) \nThe Dragon's cave.(D)\nOr you can explore caves along the road to Darmius.\nType 'Explore' to walk along the road.(E)");
            string choice = Console.ReadLine();
            if (choice == "The cave of the Frost Giants" || choice == "FG")
            {
                Console.WriteLine("You enter the cave cautiously. You hear grunts and groans.\nYou are scared. But you walk deeper into the cave.\nThe frost giants spot you. You ready your weapon but they look afraid.\nThey take your weapon and they give it back to you bigger and better. You escape unscathed and with excitement.");
                weaponStrength += 20;
                Console.WriteLine("Your health is: " + health + "\n Your weapon strength is: " + weaponStrength + "\nYour armor is: " + armor);
                Console.WriteLine("You continue your adventure...");
                Console.WriteLine("You find another cave that you have never seen in your years of exploring.\nIt's mouth is very small but it may be just enough space for you.");
                Console.WriteLine("\n(yes/no) Would you like to enter the cave? ");

                choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Console.WriteLine("You enter the cave. It is dark so you turn on your light. It leads nowhere but there is a key inside. You pick it up and crawl out.");
                    Console.WriteLine("You head to the city of Darmius. You know that if you go through the forest it will be faster but the road would be safer.");
                    Console.WriteLine("\n(yes/no) Would you like to go through the forest? ");

                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        Console.WriteLine("You enter the forest and see a rock with a chest on it.\nYou remember you found a key.");
                        Console.WriteLine("\n(yes/no) Do you want to open the chest?");

                        choice = Console.ReadLine();
                        if (choice == "yes")
                        {
                            Console.WriteLine("You open the chest, there is an acid spitting lizard inside. It spits acid on your face and you die.\n GAME OVER");
                        }


                        else if (choice == "no")
                        {
                            Console.WriteLine("You walk past and continue your adventure...");
                        }
                    }

                    else if (choice == "no")
                    {
                        Console.WriteLine("You head on the road and reach Darmius");
                        Console.WriteLine("You have heat sickness and you are beat up but your journey ends.");
                        Console.WriteLine("\nHealth = " + health + "\nWeapon strength = " + weaponStrength + "\nArmor = " + armor);
                    }
                }
                else if (choice == "no")
                {
                    Console.WriteLine("You walk past and continue your adventure...");
                }
            }

            else if (choice == "The Webspinner's cave" || choice == "W")
            {
                Console.WriteLine("You enter the cave. You are frightened.\nYou see it. It's half woman half spider.\nYou've never seen anything quite as big. You pull out your sword with confidence and charge at it.\nShe slashes you with her leg. You get knocked down but you get back up and fight.\nYou slash her legs so she cannot strike you. She falls to the ground and you stab her in the head.\nShe dies, you are injured but you take her web and it binds with your armor making it stronger.");
                armor += 50;
                health -= 20;
                Console.WriteLine("Your health is: " + health + "\n Your weapon strength is: " + weaponStrength + "\nYour armor is: " + armor);
                Console.WriteLine("You exit the cave. You come across an old man. He challenges you to a fight.");
                Console.WriteLine("(yes/no) Would you like to fight him?");
                choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Console.WriteLine("You get your fists ready but he draws his sword and slices your neck.\nGAME OVER");
                }
                else if (choice == "no")
                {
                    Console.WriteLine("You continue your journey to Darmius. ");
                    Console.WriteLine("You come across your favorite cave system. There are rubies and emeralds and also gold and other precious metals.\nBut it is never quiet, there are always monsters here. You enter the mouth of the cave.");
                    Console.WriteLine("You know this cave like the back of your hand. You gather some lapis lazuli.\nYou hear a rumble and a thump. You draw your sword and slash behind you. You kill a cave crawler.\nA mysterious creature that is usually never alone.\nYou shrug it off but all of the sudden you are being dragged.\nIt's a lycan. It snarls and growls. You can't get away...");
                    Console.WriteLine("You wake up. It's dark and it smells like blood.\nYou try to stand but you cant feel your legs. You look down and they are gone. Your legs are gone.\nThere are dead cave crawlers everywhere. It's a pack of lycans not just one.\nThey aren't there, they left you.\nYou crawl out of the cave and lay sit up under a tree.\nYou find the pegasus call you have in your bag. It comes.\nYou are starting to faint but the cold air is keeping you awake.");
                    Console.WriteLine("You see the city of Darmius. It's beautiful.\nYou've never been on a pegasus. It lands and you fall off.\nYou crawl up the palace steps. You faint.");
                    health = health - 50;
                    armor -= 100;
                    weaponStrength -= 20;
                    Console.WriteLine("Your health is: " + health + "\nYour weapon strength is: " + weaponStrength + "\nYour armor is: " + armor);
                    Console.WriteLine("You wake up in the hospital.\n(yes/no) The nurse asks if you would like a potion.");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        Console.WriteLine("You take the potion and you fall back asleep...");
                    }
                    else if (choice == "no")
                    {
                        Console.WriteLine("You refuse the potion and you fall back asleep...");
                    }

                }
            }

            else if (choice == "The Dragon's cave" || choice == "D")
            {
                Console.WriteLine("You enter the cave. You don't see anything. You walk further and the dragon swoops down.\nHe stomps on you. You die.");
                health = 0;
                armor = 0;
                Console.WriteLine("Your health is: " + health + "\nYour armor is: " + armor + "\nGAME OVER...");
                Thread.Sleep(4500);
                Console.WriteLine("Or so you thought...\nopen your eyes...\nOpen Your Eyes...\nOPEN YOU EYES!...");
                Console.WriteLine("(yes/no)Would you like to open your eyes?");
                for (int timeToAnswer = 5; timeToAnswer > 0; --timeToAnswer)
                {
                    Console.WriteLine(timeToAnswer + " seconds left to answer...");
                    Thread.Sleep(1000);
                    if (timeToAnswer == 1)
                    {
                        break;
                    }
                }
                choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Console.WriteLine("You open your eyes, everything is white but you see a gold humanoid figure.\nYou realize it's armor. You also see gold swords and maces.\nTake it, it's yours you hear.\n You get up and put the armor on. You grab a sword and you feel a rush of energy.\nNot energy, life.");
                    Console.WriteLine("You jolt awake. You are in the Dragon's cave again. He sees you and charges for you. You stick out your sword in fear and you hear a roar.\n It's dead. You look around and see the ground is charred.\nIt breathed fire on you but you're fine. You're immortal.");
                    Console.WriteLine("Your health is: ∞\nYour weapon strength is: 10,000\nYour armor is: ∞");
                }
                else if (choice == "no")
                {
                    Console.WriteLine("You don't open your eyes. Darkness consumes you.\nYou feel evil rushing through you. Your skin and insides feels like they are burning.");
                    Console.WriteLine("It feels like your limbs are growing. You have a pain in your back.\nIt gets worse and worse.");
                    Console.WriteLine("Do you want to check your back?");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        Console.WriteLine("You see wings. You look around and you see your own dead body.\nYou look at your skin and it is red and scaley.\nIt seems like you have become the dragon that killed you.\n You hear someone asking your name. You say my name is " + name + ".");
                        Console.WriteLine("You fly to the city of Darmius and burn the whole city with one breath. You have taken damage.");
                        Console.WriteLine("(yes/no) Would you like to start the healing process?");
                        choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "yes":
                                Console.WriteLine("You begin to heal and you fly away.");
                                break;
                            case "no":
                                Console.WriteLine("You don't heal and your time as a dragon comes to an end.");
                                health = 0;
                                armor = 0;
                                Console.WriteLine("Your health is: " + health + "\nYour armor is: " + armor);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You handle the pain and you fly away.");
                    }

                }
            }

            else if (choice == "Explore" || choice == "E")
            {
                health = 100;
                weaponStrength = 100;
                armor = 100;
                Console.WriteLine("Your health is: " + health + "\nYour weapon strength is: " + weaponStrength + "\nYour armor is: " + armor);
                Console.WriteLine("You find a tomb. Would you like to enter it? (yes/no)");
                choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Console.WriteLine("There is a mummy inside. You attack it and kill it. You use its wrap to make your armor stronger.");
                    armor += 10;
                    Console.WriteLine("Your health is: " + health + "\nYour weapon strength is: " + weaponStrength + "\nYour armor is: " + armor);
                    Console.WriteLine("You go to your favorite pond. There is a woman there. Would you like to talk to her? (yes/no)");
                    choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        Console.WriteLine("You approach her but she runs away in fear. You wonder why but you continue on your journey.");
                        Console.WriteLine("Would you like to drink from the pond? (yes/no)");
                        choice = Console.ReadLine();
                        if (choice == "yes")
                        {
                            Console.WriteLine("You drink from the water. It is not like it used to be, it has been poisoned.");
                            health -= 70;
                            Console.WriteLine("Your health is: " + health);
                            Console.WriteLine("(yes/no) Would you like to try to find a hospital?");
                            choice = Console.ReadLine();
                            if (choice == "yes")
                            {
                                Console.WriteLine("You find a hospital but you are too sick to continue your journey...");
                                health = 0;
                                Console.WriteLine("Your heath is: 0\nGAME OVER");
                            }
                            else
                            {
                                Console.WriteLine("Your life is coming to an end");
                                int timeLeft = 5;
                                while(timeLeft > 0)
                                {
                                    Console.WriteLine("Time left alive... " + timeLeft);
                                    Thread.Sleep(1000);
                                    timeLeft -= 1;
                                    Console.WriteLine("GAME OVER");
                                }
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("You walk over to the pond and ignore her.");
                    }
                }
                else
                {
                    Console.WriteLine("You continue walking...");
                }
               
            }
            Console.ReadKey();
        }
    }
}
     
    