using System;

public class Race_Creation
{
	public Race_Creation()
	{
        int correct = 0;
        string Race, Input;
        
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
                if (Input == "YES")
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
    }
}
