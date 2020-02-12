using System;

public class Class_Creation
{
	public Class_Creation()
	{
        int correct = 0;
        string Class, Input;
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
                Console.WriteLine("Science +2");
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
    }
}
