using System;

public class Menu
{
    int correct = 0;
    int arrayCount = 0;
    int playerQuestProgress = 0;
    int playerQuestGoal;
    int player_laserDamage = 2;
    int player_photonTorpedoDamage = 2;
    int player_disruptorBeams = 2;
    int player_photonCannons = 2;
    int player_healthPoints = 20;
    int player_shieldPoints = 12;

    string Input;
    string Gender;
    string Race;
    string Class;
    string playerQuest;
    string playerQuestEnemy;
    string[] Inventory = new string[20];

    public Menu()
	{

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

                    } while (correct == 0);
                    if (Input == "EXIT")
                    {
                        correct = 2;
                    }

                }
                else { }

            }
        } while (correct != 2);


    }
}
