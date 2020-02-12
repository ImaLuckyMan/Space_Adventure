using System;

public class Racial_Bonus
{
    int player_strength = 0;
    int player_constitution = 0;
    int player_dexterity = 0;
    int player_intelligence = 0;
    int player_wisdom = 0;
    int player_chrisma = 0;
    int player_science = 0;
    int player_exploration = 0;
    int player_theft = 0;
    int player_tradeCraft = 0;
    int player_perception = 0;
    int player_resistance = 0;
    int player_bonusDamage = 0;
    int player_resistToxins = 0;
    int player_healthRegen = 0;

    string Race;
	public Racial_Bonus()
	{
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
            player_healthRegen = player_healthRegen + 12;
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
            player_bonusDamage = player_bonusDamage + 2;
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
    }
}
