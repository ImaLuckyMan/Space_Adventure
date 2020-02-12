using System;

public class Inventory
{
    int arrayCount = 0;
    
    string[] inventory;
    string Input;

	public Inventory()
	{
        inventory[0] = "a";
        inventory[1] = "b";
        inventory[2] = "snails";

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
                Console.WriteLine("{0}", inventory[arrayCount]);
            }
        }
        else
        {

        }

	}
}
