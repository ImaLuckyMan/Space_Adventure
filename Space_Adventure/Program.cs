using System;

namespace Space_Adventure
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ints:
            int correct = 0;
            int player_science = 0;
            int player_exploration = 0;
            int player_theft = 0;
            int player_tradeCraft = 0;
            int player_strength=0;
            int player_constitution=0;
            int player_dexterity=0;
            int player_intelligence=0;
            int player_wisdom=0;
            int player_chrisma=0;
            int player_perception = 0;
            int player_resistance = 0;
            int player_bonusDamage = 0;
            int player_resistToxins = 0;
            int player_healthRegen = 0;
            int arrayCount = 0;
            int player_attackType = 0;
            int player_laserDamage = 2;
            int player_disruptorBeams = 2;
            int player_photonTorpedoDamage = 2;
            int player_photonCannons = 2;
            int player_healthPoints = 20;
            int player_shieldPoints = 12;
            int enemy_healthPoints;
            int enemy_maximumDamage;
            int player_inventoryMoney = 0;
            int player_inventoryExperience = 0;
            int player_rewardExperience = 0;
            int player_rewardGold = 0;
            int playerQuestProgress = 0;
            int playerQuestGoal;
            int questRewardExp;
            int questRewardGold;
            int player_exp = 0;

            //Strings
            string Gender;
            string Race;
            string Class;
            string[] Inventory = new string [20];
            string Input;
            string enemyName;
            string playerQuest = " ";
            string questAccepted;
            string playerQuestEnemy;


            //Character Creation
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a gender below:");
                Console.Write("Male / Female : ");
                Gender = Console.ReadLine().ToUpper();
                if (Gender == "MALE" || Gender == "FEMALE")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Race Creation:
            //TODO - FIX the Bonus levels for each Race
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a race as below : ");
                Console.WriteLine("Human");
                Console.WriteLine("Klingon");
                Console.WriteLine("Swarm");
                Console.WriteLine("Borg");
                Console.WriteLine("Orions");
                Console.WriteLine("Bajorans");
                Console.WriteLine("The Q");
                Console.WriteLine("Romulans");
                Console.WriteLine("Andorins");
                Console.WriteLine("Tholians");
                Console.WriteLine("Gorn");
                Console.WriteLine("Ferengi");
                Console.WriteLine("Cardassians");
                Console.WriteLine("Dominion");
                Console.WriteLine("Vulcan");
                Console.Write("Your Choice : ");
                Race = Console.ReadLine().ToUpper();
                if (Race == "HUMAN")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength");
                    Console.WriteLine("Constitution");
                    Console.WriteLine("Intelligence");
                    Console.WriteLine("Wisdom");
                    Console.WriteLine("Chrisma");
                    Console.WriteLine("Science");
                    Console.WriteLine("Exploration");
                    Console.WriteLine("Theft");
                    Console.WriteLine("Trade Craft");
                    Console.WriteLine("Perception");
                    Console.WriteLine("Resistance");
                    Console.WriteLine("Bonus Damage");
                    Console.WriteLine("Resist Radiation");
                    Console.WriteLine("Regen Health");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if(Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }

                }
                if (Race == "KLINGON")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "SWARM")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "BORG")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "ORIONS")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "BAJORANS")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "THE Q")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "ROMULANS")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "ABDORINS")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "THOLIANS")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "GORN")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "FERENGI")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "CARDASSIANS")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "DOMINION")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Race == "Vulcan")
                {
                    Console.Clear();
                    Console.WriteLine("This race gives a bonus to the following stats:");
                    Console.WriteLine("Strength + 10");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }

            } while (correct == 0);
            correct = 0;

            //Class Creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose a class as below:");
                Console.WriteLine("Science");
                Console.WriteLine("Explorer");
                Console.WriteLine("Space Pirate");
                Console.WriteLine("Trade Ship");
                Class = Console.ReadLine().ToUpper();
                if (Class == "SCIENCE" || Class == "SCIENTIST")
                {
                    Console.Clear();
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("Science +2" );
                    Console.Write("Is this the Class you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Class == "EXPLORATION" || Class == "EXPLORER" || Class == "EXPLORER")
                {
                    Console.Clear();
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("Wisdom + 1");
                    Console.WriteLine("Exploration + 10");
                    Console.WriteLine("Trade Craft + 2");
                    Console.WriteLine("Perception + 1");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Class == "PIRATE" || Class == "SPACE PIRATE")
                {
                    Console.Clear();
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("Theft +2");
                    Console.WriteLine("Trade Craft +1");
                    Console.WriteLine("Perception +2");
                    Console.Write("Is this the race you wish to play? Enter Yes/No : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                if (Class == "TRADE" || Class == "TRADE SHIP")
                {
                    Console.Clear();
                    Console.WriteLine("This class gives a bonus to the following stats:");
                    Console.WriteLine("Chrisma +2");
                    Console.WriteLine("Better Trade Prices +10");
                    Console.WriteLine("Perception +2");
                    Console.Write("Is this the race you wish to play? Enter Yes/No  : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        correct = 1;
                    }
                    if (Input == "NO")
                    {
                        correct = 0;
                    }
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Bonuses:
            //Race Bonuses
            //TODO - CORRECT RACE BONUSES
            if (Race == "HUMAN")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "KLINGON")
            {
                player_strength = player_strength + 10;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "SWARM")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "BORG")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "ORIANS")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "BAJORANS")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen = player_healthRegen +12;
            }
            if (Race == "THE Q")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "ROMULANS")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "ABDORINS")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception = player_perception + 10;
                player_resistance = player_resistance = 25;
                player_bonusDamage = player_bonusDamage + 10;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "THOLIANS")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "GORN")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "FERENGI")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception = player_perception + 10;
                player_resistance = player_resistance + 1;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "CARDASSIANS")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception = player_perception + 2;
                player_resistance = player_perception + 2;
                player_bonusDamage = player_bonusDamage +2;
                player_resistToxins++;
                player_healthRegen++;
            }
            if (Race == "DOMINION")
            {
                player_strength++;
                player_constitution++;
                player_dexterity++;
                player_intelligence++;
                player_wisdom++;
                player_chrisma++;
                player_science++;
                player_exploration++;
                player_theft++;
                player_tradeCraft++;
                player_perception++;
                player_resistance++;
                player_bonusDamage++;
                player_resistToxins++;
                player_healthRegen++;
            }

            //CLASS Bonus:
            if (Class == "SCIENCE")
            { }
            if (Class == "EXPLORER")
            { }
            if (Class == "SPACE PIRATE")
            { }
            if (Class == "TRADE SHIP")

            //or we can go something like this:
            if (Class == "Galaxy Class")
            { }
            if (Class == "Constitution Class")
            { }
            if (Class == "Intrepid Class")
            { }
            if (Class == "Sovereign Class")
            { }
            if (Class == "Miranda Class")
            { }
            if (Class == "Nebula Class")
            { }
            if (Class == "Excelsior Class")
            { }

            // Player Description Writeout
            Console.Clear();
            Console.WriteLine("Your Full Character Description is : ");
            Console.WriteLine("A {0} {1} {2}", Gender, Race, Class);
            Console.WriteLine("Strength Points : {0}", player_strength);
            Console.WriteLine("Constitution Points : {0}", player_constitution);
            Console.WriteLine("Intelligence Points : {0}", player_intelligence);
            Console.WriteLine("Wisdom Points {0}", player_wisdom);
            Console.WriteLine("Chrisma Points {0}", player_chrisma);
            Console.WriteLine("Science Points {0}", player_science);
            Console.WriteLine("Exploration {0}", player_exploration);
            Console.WriteLine("Theft Points {0}", player_theft);
            Console.WriteLine("Trade Craft Points {0}", player_tradeCraft);
            Console.WriteLine("Perception Points {0}", player_perception);
            Console.WriteLine("Resistance Points {0}", player_resistance);
            Console.WriteLine("Bonus Damage Points {0}", player_bonusDamage);
            Console.WriteLine("Resist Radiation Points {0}", player_resistToxins);
            Console.WriteLine("Regen Health Points {0}", player_healthRegen);
            Console.WriteLine();

            Inventory[0] = "a";
            Inventory[1] = "b";
            Inventory[2] = "snails";

            Console.Clear();
            Console.WriteLine("Inventory Test: type inventory below");
            Input = Console.ReadLine().ToUpper();
            //Inventory System:
            if (Input == "INVENTORY" || Input == "INV")
            {
                Console.Clear();
                Console.WriteLine("Your Inventory Contains : ");
                for (arrayCount = 0; arrayCount < 20; arrayCount++)
                {
                    int inventory_position = arrayCount + 1;
                    Console.SetCursorPosition(0, inventory_position);
                    Console.WriteLine("{0}", Inventory[arrayCount]);
                }
            }
            else
            {

            }

            // Enemy Declair System:
            enemyName = "Bad Guy";
            enemy_healthPoints = 12;
            enemy_maximumDamage = 2;

            // Combat System:

            do
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Your Health is at {0} Points, Your sheilds are at {1} points", player_healthPoints, player_shieldPoints);
                Console.WriteLine("The {0}s Health is at {1} Points", enemyName, enemy_healthPoints);
                Console.WriteLine("Enter the number for the type of attach that you wish to perform : ");
                Console.WriteLine("1. Lasers");
                Console.WriteLine("2. Photon Missle");
                Console.WriteLine("3. Disrupter Beams");
                Console.WriteLine("4. Photon Cannons");
                player_attackType = Convert.ToInt32(Console.ReadLine());
                if (player_attackType == 1)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, player_laserDamage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + player_laserDamage;
                        Console.WriteLine("You did a critical Hit, and added {0} Skill points of damage", player_laserDamage);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, enemyName);
                    enemy_healthPoints = enemy_healthPoints - Random_Damage_Roll;
                }
                if (player_attackType == 2)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, player_photonTorpedoDamage);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + player_photonTorpedoDamage;
                        Console.WriteLine("You did a critical hit, and added {0} Skill points of damage", player_photonTorpedoDamage);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, enemyName);
                    enemy_healthPoints = enemy_healthPoints - Random_Damage_Roll;
                }
                if (player_attackType == 3)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, player_disruptorBeams);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + player_disruptorBeams;
                        Console.WriteLine("You did a critical hit, and add {0} Skill points of damage", player_disruptorBeams);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, enemyName);
                    enemy_healthPoints = enemy_healthPoints - Random_Damage_Roll;
                }
                if (player_attackType == 4)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, player_photonCannons);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    Random Skill_Point_Roll = new Random();
                    int Skill_Point_Outcome = Skill_Point_Roll.Next(0, 11);
                    if (Skill_Point_Outcome > 6 && Random_Damage_Roll > 0)
                    {
                        Random_Damage_Roll = Random_Damage_Roll + player_photonCannons;
                        Console.WriteLine("You did a critical hit, and add {0} Skill points of damage", player_photonCannons);
                    }
                    else { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, enemyName);
                    enemy_healthPoints = enemy_healthPoints - Random_Damage_Roll;
                }
                else { }
                if (enemy_healthPoints > 0)
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, enemy_maximumDamage);
                    Console.WriteLine("The {0} Strikes back, and deal {1} Points of Damage", enemyName, Random_Enemy_Damage_Roll);
                    player_healthPoints = player_healthPoints - Random_Enemy_Damage_Roll;
                    Console.WriteLine();
                }
                else { }

            } while (player_healthPoints > 0 && enemy_healthPoints > 0);
            Console.Clear();
            if (enemy_healthPoints < 0)
            {
                enemy_healthPoints = 0;
            }
            if (player_healthPoints < 0)
            {
                player_healthPoints = 0;
            }
            Console.WriteLine("Your Health is at {0} Points, Your Shields are at {1} Points", player_healthPoints, player_shieldPoints);
            Console.WriteLine("The {0}s Health is at {1} Points", enemyName, enemy_healthPoints);
            Console.WriteLine("Enter the number for the type of attach you wish to perform:");
            Console.WriteLine("1. Lasers");
            Console.WriteLine("2. Photon Missle");
            Console.WriteLine("3. Disrupter Beams");
            Console.WriteLine("4. Photon Cannons");
            if (enemy_healthPoints > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle.");
                Console.ReadLine();
            }
            if (player_healthPoints > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You won the battle.");
                Console.WriteLine();
            }

            // Quest Giving System:
            questRewardExp = 20;
            questRewardGold = 50;
            playerQuestGoal = 3;
            playerQuestEnemy = "Tribbles";

            do
            {
                correct = 0;
                Console.Clear();
                if (playerQuest != " ")
                {
                    Console.WriteLine("You have to finish your current quest, in order to get a new one.");
                    correct = 1;
                }
                if (playerQuest == " ")
                {
                    Console.Clear();
                    Console.WriteLine("I would gladly pay you to kill the 3 tribbles, thats annoying me, out in my air vents.");
                    Console.WriteLine("Reward: {0} Gold, and {1} EXP", questRewardGold, questRewardExp);
                    Console.Write("Do you accept? Yes/No? : ");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "NO")
                    {
                        correct = 1;
                        questAccepted = "NO";
                    }
                    if (Input == "YES")
                    {
                        Console.WriteLine("The quest has been accepted.");
                        playerQuest = "The Captain would gladly pay you 50 and give you 20 EXP, to rid his air vents of the 3 tribbles.";
                        correct = 1;
                        questAccepted = "YES";
                    }
                }
            } while (correct == 0);
            Console.ReadLine ();

            // MENU WRITEOUT
            do
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("Enter Quest, to see your current quest");
                Console.WriteLine("Enter Inventory, to see your Inventory content");
                Console.WriteLine("Enter Status, to see in detail how your character is doing");
                Console.WriteLine("Enter Exit, to quit the menu");
                Input = Console.ReadLine().ToUpper();
                if (Input == "QUEST" && playerQuest != " ")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(playerQuest);
                        Console.WriteLine("Progress: {0}/{1} {2}", playerQuestProgress, playerQuestGoal, playerQuestEnemy);
                        Console.WriteLine("< BACK");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        {
                            correct = 1;
                        }
                        if (Input != "BACK")
                        {

                        }
                    } while (correct == 0);
                }
                if (Input == "QUEST" && playerQuest == " ")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have any active quests at the moment");
                        Console.WriteLine("< back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        {
                            correct = 1;
                        }
                        if (Input != "BACK")
                        {

                        }
                        
                    } while (correct == 0);

                    if (Input == "INVENTORY" || Input == "INV")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Your Inventory Contains: ");
                            for (arrayCount = 0; arrayCount < 20; arrayCount++)
                            {
                                int inventoryPosition = arrayCount + 1;
                                Console.SetCursorPosition(0, inventoryPosition);
                                Console.WriteLine("{0}", Inventory[arrayCount]);
                            }
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            { correct = 1; }
                            if (Input != "BACK")
                            { correct = 0; }
                        } while (correct == 0);
                    }
                    if (Input == "STATUS" || Input == "STAT")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("You character is:");
                            Console.WriteLine("A {0} {1} {2}", Gender, Race, Class);
                            Console.WriteLine("1. Lasers Skill Points {0}", player_laserDamage);
                            Console.WriteLine("2. Photon Missle Skill Points {1}", player_photonTorpedoDamage);
                            Console.WriteLine("3. Disrupter Beams Skill Points {2}", player_disruptorBeams);
                            Console.WriteLine("4. Photon Cannons Skill Points {3}", player_photonCannons);
                            Console.WriteLine("{0} Health Points, {1} Shield Points, {2} Experience Points", player_healthPoints, player_shieldPoints, player_exp);
                            Console.WriteLine("< BACK");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            {
                                correct = 1;
                            }
                            if (Input != "BACK")
                            {
                                correct = 0;
                            }
                            
                        }while (correct == 0) ;
                        if (Input == "EXIT")
                        { 
                            correct = 2; 
                        }
                        
                    }
                    else { }

                } 
            } while (correct != 2);


            /* Possible SHIP UPGRADES
             * Upgraded Lasers
             * Upgraded Torpedoes
             * Upgraded Cannons
             * Cloaking device
             * Communicator
             * Deflector shields
             * Holodeck
             * Hypospray
             * Impulse drive
             * Jefferies tube
             * LCARS
             * Medicine
             * Replicator
             * Transporter
             * Shuttle Craft
             */

            /* Possible STAR SHIPS and DESCRIPTIONS
             * Prometheus U.S.S. (NX-59650) Experimental prototype Starfleet vessel, registry NX-59650, the Prometheus is designed for deep-space, tactical assignments. 
             * Constructed in the Beta Antares Shipyards and launched on Stardate 50749.5, the Prometheus is the first starship of its class, as well as 
             * the fastest and most innovative vessel in Starfleet.
             */


            Console.ReadLine();
        }
        
        
    }
}
