using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TBA_2._0_CSharp
{
    class Program
    {
            /**
 * Created by arodriguez on 10/6/2016.
 */
            //region Variable Declaration/Initialization
            static String[] huntees = new String[] { "Luanna Pillot", "Odell Tank", "Jenni Nealy", "Jenine Earheart", "Dollie Kavanagh", "Warren Burrus", "Bart Sampson", "Janise Pomerantz", "Cristi Carlin", "Dionna Oum" };
            static int[] hunteeArmor = new int[] { 40, 10, 25, 20, 70, 15, 100, 58, 78, 30 };
            static int[] hunteeAttack = new int[] { 5, 10, 14, 12, 20, 22, 60, 14, 16, 17 };
            static String[] dnames = new String[] { "David Baker", "David Baker" };
            static int hunteeHealth = 50;
            static int characterArmor;
            static int characterWeapon;
            static int xp = 0;
            static int xpToLvlUp = 20;
            static int level = 1;
            static int baseWeaponCost = 50;
            static int baseArmorCost = 50;
            static int armorLvL = 1;
            static int weaponLvL = 1;
            static int baseAttack = 50;
            static int baseArmor = 50;
            static int sck = 50;
            static int kah = 70;
            static int cm = 100;
            static int armorDef = 10;
            static double cash;
            static double bucks = 100;
            static double health = 100.0;
            static int pistol = 70;
            static int stunGun = 40;
            static int laserDagger = 100;
            static int maxHealth = 100;
            static Random rand = new Random();
            //endregion
            public static void main(String[] args)
            {
                while (true)
                {
                    health = 100;
                    Console.WriteLine("Welcome to Bounty Hunter X");
                    Console.WriteLine("What is your name agent?");
                    string name = Console.ReadLine();
                    if (name == ("David Baker"))
                    {
                        Console.WriteLine("You win!!");
                        return;
                    }
                    Console.WriteLine(name + " huh? Well your name won't save your life. Would you like a rundown of the operation? (y/n)");

                    while (true)
                    {
                        String choice1 = Console.ReadLine();
                        if (choice1 == ("y"))
                        {
                            Console.WriteLine("Ok, what we're doing is top secret.");
                            Console.WriteLine("We are hunting the most dangerous criminals on the planet");
                            Console.WriteLine("We have given you a couple of weapon choices and armor choices. Pick one of each");
                            Console.WriteLine("Choose your weapon:\nPistol\nStun gun\nLaser Dagger");
                            String weaponChoice = Console.ReadLine();
                            if (weaponChoice == ("Pistol"))
                            {
                                Console.WriteLine("You chose the pistol. It's damage is: " + pistol);
                                characterWeapon = pistol;
                            }
                            else if ("Stun gun" == (weaponChoice))
                            {
                                Console.WriteLine("You chose the stun gun. It's damage is: " + stunGun);
                                characterWeapon = stunGun;
                            }
                            else if (weaponChoice == ("Laser Dagger"))
                            {
                                Console.WriteLine("You chose the Laser Dagger. It's damage is: " + laserDagger);
                                characterWeapon = laserDagger;
                            }
                            break;
                        }
                        else if (choice1 == ("n"))
                        {
                            Console.WriteLine("Alright agent.");
                            Console.WriteLine("Choose your weapon:\nPistol\nStun gun\nLaser Dagger");
                            String weaponChoice = Console.ReadLine();
                            if (weaponChoice == ("Pistol"))
                            {
                                Console.WriteLine("You chose the pistol. It's damage is: " + pistol);
                                characterWeapon = pistol;
                            }
                            else if (weaponChoice == ("Stun gun"))
                            {
                                Console.WriteLine("You chose the stun gun. It's damage is: " + stunGun);
                                characterWeapon = stunGun;
                            }
                            else if (weaponChoice == ("Laser Dagger"))
                            {
                                Console.WriteLine("You chose the Laser Dagger. It's damage is: " + laserDagger);
                                characterWeapon = laserDagger;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not an option...");
                            health -= 0.1;
                            Console.WriteLine("Your health is now: " + health.ToString("F2"));
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Now it's time to choose your armor");
                        Console.WriteLine("Choose your armor:\nStreet clothes and kevlar - SCK\nKevlar body armor and helmet - KAH\nChainmail mesh - CM");
                        String armorChoice = Console.ReadLine();
                        if (armorChoice == ("SCK"))
                        {
                            Console.WriteLine("You chose street clothes and kevlar. Your armor is: " + sck);
                            characterArmor = sck;
                            break;
                        }
                        else if (armorChoice == ("KAH"))
                        {
                            Console.WriteLine("You chose kevlar body armor and helmet. Your armor is: " + kah);
                            characterArmor = kah;
                            break;
                        }
                        else if (armorChoice == ("CM"))
                        {
                            Console.WriteLine("You chose chainmail mesh. Your armor is: " + cm);
                            characterArmor = cm;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not an option...");
                        }
                    }
                        Thread.Sleep(2000);                 //1000 milliseconds is one second.
                    Console.WriteLine("Are you ready to go hunting?\n \n");
                    //region MainGameLoop
                    while (true)
                    {
                        Console.WriteLine("Hub - Start Hunting\nDeepWeb - Go to the DeepWeb\nC - Character profile\nD - Fight David Baker");
                        String choice4 = Console.ReadLine();
                        if (choice4 == ("Hub"))
                        {
                            int hunteeName = rand.nextInt(huntees.length);
                            int hArmor = rand.nextInt(hunteeArmor.length);
                            int hAttack = rand.nextInt(hunteeAttack.length);
                            int hunteeLevel = GetHunteeLevel();
                            Console.WriteLine("Welcome to the hub. This is where you get your case files. This is also where you become a bounty hunter.");
                            Console.WriteLine("It's time to get your case...");
                            Console.WriteLine("Here is your case: \nName: " + huntees[hunteeName] + "\nArmor: " + hArmor + "\nAttack: " + hAttack);
                            Console.WriteLine("Are you ready to fight? (y/n)");
                            while (true)
                            {
                                String choice5 = Console.ReadLine();
                                if (choice5 == ("y"))
                                {
                                    hunteeHealth = 50 + 10 * hunteeLevel;
                                    while (health > 0 && hunteeHealth > 0)
                                    {
                                        FightSequence(hunteeName);
                                        Console.WriteLine("Enter H, A, or C");
                                        String choice6 = Console.ReadLine();
                                        if (choice6 == ("H"))
                                        {
                                            if (health >= 100)
                                            {
                                                Console.WriteLine("Sorry, your health is already maxed!");
                                            }
                                            else if (health <= 100)
                                            {
                                                if (bucks >= 10)
                                                {
                                                    health = 100;
                                                    Console.WriteLine("Your health is now: " + health);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Sorry, not enough bucks!");
                                                }
                                            }
                                        }
                                        else if (choice6 == ("A"))
                                        {
                                            int damage = CalculateDmg(baseAttack, weaponLvL, characterWeapon, hunteeArmor[hunteeName], hunteeLevel, false, false);
                                            hunteeHealth = hunteeHealth - damage;
                                            Console.WriteLine("You attack and deal " + damage + " damage.");
                                            if (hunteeHealth > 0)
                                            {
                                                damage = CalculateDmg(baseArmor, armorLvL, armorDef, hunteeAttack[hunteeName], hunteeLevel, true, false);
                                                health = health - damage;
                                                Console.WriteLine(huntees[hunteeName] + " attacked and dealt " + damage + " damage");
                                                continue;
                                            }
                                            else if (hunteeHealth <= 0)
                                            {
                                                Console.WriteLine("You killed, " + huntees[hunteeName] + " congrats " + name);
                                                break;
                                            }
                                        }
                                        else if (choice6 == ("C"))
                                        {
                                            CharacterProfile();
                                        }
                                        else
                                        {
                                            Console.WriteLine("That was not an option...");
                                            continue;
                                        }
                                    }
                                    if (health > 0)
                                    {
                                        int min = (int)(10 * hunteeLevel);
                                        int max = (int)(10 * hunteeLevel * 1.8);
                                        int exp = rand.nextInt(max - min + 1) + min;
                                        xp = xp + exp;
                                        cash = rand.nextInt(max + min - 1);
                                        bucks = cash + bucks;
                                        Console.WriteLine("You killed " + huntees[hunteeName] + ", you got " + exp + " experience and " + cash + " cash");
                                        if (xp >= xpToLvlUp)
                                        {
                                            level = level + 1;
                                            xpToLvlUp = (int)(xpToLvlUp + 10 * Math.pow(level, 2));
                                            maxHealth += 10;
                                            health = maxHealth;
                                            bucks += 50;
                                            Console.WriteLine("Congrats agent " + name + " you are now level " + level + "\nYour health is now: " + health);
                                        }
                                    }
                                }
                                else if (choice5 == ("n"))
                                {
                                    Console.WriteLine("Ok then... we'll see you soon");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, that was not an option...");
                                    continue;
                                }
                                break;
                            }
                            if (health < 0)
                            {
                                Console.WriteLine("Health: " + health);
                                Console.WriteLine("Dammit agent, you died.");
                                Console.WriteLine("Press any key to try again");
                                Console.ReadLine();
                                break;
                            }
                        }
                        else if (choice4 == ("DeepWeb"))
                        {
                            DeepWeb();
                        }
                        else if (choice4 == ("C"))
                        {
                            CharacterProfile();
                        }
                        else if (choice4 == ("D"))
                        {
                            while (true)
                            {
                                int dname = rand.Next(dnames);
                                int dhealth = 1000;
                                Console.WriteLine("You chose to fight David Baker... Prepare to Die...");
                                while (health > 0 && dhealth > 0)
                                {
                                    DBFightSequence(dname);
                                    int dArmor = 1000;
                                    int dAttack = 500;
                                    Console.WriteLine("Enter H, A, or C");
                                    String choice6 = Console.ReadLine();
                                    if (choice6 == ("H"))
                                    {
                                        if (health >= 100)
                                        {
                                            Console.WriteLine("Sorry, your health is already maxed!");
                                        }
                                        else if (health <= 100)
                                        {
                                            if (bucks >= 10)
                                            {
                                                health = 100;
                                                Console.WriteLine("Your health is now: " + health);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Sorry, not enough bucks!");
                                            }
                                        }
                                    }
                                    else if (choice6 == ("A"))
                                    {
                                        int damage = CalculateDmg(baseAttack, weaponLvL, characterWeapon, 100, 100, false, false);
                                        hunteeHealth = hunteeHealth - damage;
                                        Console.WriteLine("You attack and deal " + damage + " damage.");
                                        if (hunteeHealth > 0)
                                        {
                                            damage = CalculateDmg(100, 100, 100, 100, 100, true, false);
                                            health = health - damage;
                                            Console.WriteLine("David Baker attacked and dealt " + damage + " damage");
                                            continue;
                                        }
                                        else if (hunteeHealth <= 0)
                                        {
                                            Console.WriteLine("You killed, David Baker, congrats " + name);
                                            break;
                                        }
                                    }
                                    else if (choice6 == ("C"))
                                    {
                                        CharacterProfile();
                                    }
                                    else
                                    {
                                        Console.WriteLine("That was not an option...");
                                        continue;
                                    }
                                }
                                if (health < 0)
                                {
                                    Console.WriteLine("Health: " + health);
                                    Console.WriteLine("You died");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry That was not an option...");
                        }
                        if (health < 0)
                        {
                            break;
                        }
                    }
                    //endregion

                }

            }

            //region DeepWeb
            static void DeepWeb()
            {
                while (true)
                {
                    int weaponCost = weaponLvL * baseWeaponCost;
                    int armorCost = armorLvL * baseArmorCost;
                    Console.WriteLine("Welcome to the DeepWeb");
                    Console.WriteLine("Here you can buy weapon and armor upgrades and also refill your health.");
                    Console.WriteLine("A - Upgrade armor\nW - Upgrade weapon\nH - Refill health\nE - Exit DeepWeb");
                    String choice3 = Console.ReadLine();
                    if (choice3 == ("A"))
                    {
                        if (bucks >= armorCost)
                        {
                            bucks = bucks - armorCost;
                            armorLvL += 1;
                            characterArmor += 5;
                            Console.WriteLine("Congrats agent, looks like you successfully bought a weapon upgrade.\nYour weapon level is now: " + armorLvL + "\nYour weapon's strength is now: " + characterArmor);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough bucks agent!");
                        }
                    }
                    else if (choice3 == ("W"))
                    {
                        if (bucks >= weaponCost)
                        {
                            bucks = bucks - weaponCost;
                            weaponLvL += 1;
                            characterWeapon += 5;
                            Console.WriteLine("Congrats agent, looks like you successfully bought a weapon upgrade.\nYour weapon level is now: " + weaponLvL + "\nYour weapon's strength is now: " + characterWeapon);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough bucks agent!");
                        }
                    }
                    else if (choice3 == ("H"))
                    {
                        Console.WriteLine("Refilling health costs 10 bucks, are you sure you would like to refill your health? (y/n)");
                        String refillHealthChoice = Console.ReadLine();
                        if (refillHealthChoice == ("y"))
                        {
                            if (health >= 100)
                            {
                                Console.WriteLine("Sorry, your health is already maxed!");
                            }
                            else if (health < 100)
                            {
                                if (bucks >= 10)
                                {
                                    bucks -= 10;
                                    health = 100;
                                    Console.WriteLine("Your health is now full");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough bucks!");
                                }
                            }
                        }
                        else if (refillHealthChoice == ("n"))
                        {
                            Console.WriteLine("Well I can't do anything for you...");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that was not an option...");
                        }

                    }
                    else if (choice3 == ("E"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that was not an option...");
                    }
                }
            }
            //endregion
            //region GetHunteeLevel
            static int GetHunteeLevel()
            {
                int hunteeLevel;
                //random selection of level with weights
                int randVal = rand.Next(1, 1000);
                if (randVal < 100)
                {
                    hunteeLevel = level - 2;
                }
                else if (randVal < 300)
                {
                    hunteeLevel = level - 1;
                }
                else if (randVal < 900)
                {
                    hunteeLevel = level;
                }
                else if (randVal < 970)
                {
                    hunteeLevel = level + 1;
                }
                else
                {
                    hunteeLevel = level + 2;
                }
                if (hunteeLevel < 1)
                {
                    hunteeLevel = 1;
                }
                return hunteeLevel;
            }
            //endregion
            //region FightSequence
            static void FightSequence(int hunteeName)
            {
                Console.WriteLine("Your health is: " + health);
                Console.WriteLine("Your armor is: " + characterArmor);
                Console.WriteLine(huntees[hunteeName] + "'s health is: " + hunteeHealth);
                Console.WriteLine("Your attack is: " + characterWeapon);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("H - Heal for 10 bucks");
                Console.WriteLine("A - Attack target");
            }
            //endregion
            static void DBFightSequence(int hunteeName)
            {
                hunteeHealth = 1000;
                Console.WriteLine("Your health is: " + health);
                Console.WriteLine("Your armor is: " + characterArmor);
                Console.WriteLine("David Baker's health is: " + hunteeHealth);
                Console.WriteLine("Your attack is: " + characterWeapon);
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("H - Heal for 10 bucks");
                Console.WriteLine("A - Attack target");
            }
            //region CalculateDmg
            static int CalculateDmg(int baseRating, int itemLvl, int itemRating, int hunteeSkill, int hunteeLevel, bool isHunteeAttack, bool isAutoCrit)
            {

                double netRating = (baseRating * level * 1.2) + itemLvl * itemRating;
                if (isHunteeAttack)
                {
                    netRating = (hunteeSkill * 1.2 * hunteeLevel) - netRating;
                }
                else
                {
                    netRating = netRating - (hunteeSkill * 1.2 * hunteeLevel);
                }
                if (netRating < 0)
                {
                    netRating = 0;
                }

                int adjustedDmg = (int)(netRating + 10);
                int adjustedDmgMax = (int)(adjustedDmg + 10);
                int damage = randInt(adjustedDmg, adjustedDmgMax);
                if (randInt(1, 50) == 50 || isAutoCrit)
                {
                    Console.WriteLine("Critical Hit! ");
                    damage = damage * 3;
                }
                return damage;
            }
            //endregion
            //region CharacterProfile
            static void CharacterProfile()
            {
                double armorBonus = armorLvL * armorDef;
                double weaponBonus = weaponLvL * characterWeapon;
                Console.WriteLine("Character Profile: ");
                Console.WriteLine("Level: " + level);
                Console.WriteLine("Health " + health);
                Console.WriteLine("Armor: " + formatter.format(characterArmor) + "(+" + armorBonus + ")");
                Console.WriteLine("Attack: " + formatter.format(characterWeapon) + "(+" + weaponBonus + ")");
                Console.WriteLine("Bucks: " + bucks);
                Console.WriteLine("XP: " + xp + "/" + xpToLvlUp + " XP to next level");
            }
            //endregion
            //region RandomInt
            static int randInt(int min, int max)
            {
                Random rand = new Random();
                int randomNum = rand.Next((max - min) + 1) + min;
                return randomNum;
            }
            //endregion
        }

    }
}

