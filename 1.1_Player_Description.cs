using System;

public class Player_Description
{
    int player_strength     = 0;
    int player_constitution = 0;
    int player_intelligence = 0;
    int player_wisdom       = 0;
    int player_chrisma      = 0;
    int player_science      = 0;
    int player_exploration  = 0;
    int player_theft        = 0;
    int player_tradeCraft   = 0;
    int player_perception   = 0;
    int player_resistance   = 0;
    int player_bonusDamage  = 0;
    int player_resistToxins = 0;
    int player_healthRegen  = 0;

    string Gender;
    string Race;
    string Class; 
	public Player_Description()
	{
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
        
    }
}
