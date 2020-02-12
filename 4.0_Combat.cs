using System;

public class Combat
{
    int correct = 0;
    int enemy_healthPoints = 0;
    int enemy_maximumDamage = 0;
    int player_attackType=0;
    int player_healthPoints = 20;
    int player_laserDamage = 2;
    int player_photonTorpedoDamage = 2;
    int player_shieldPoints = 12;
    int player_disruptorBeams = 2;
    int player_photonCannons = 2;
    string enemyName;

	public Combat()
	{
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
    }
}
