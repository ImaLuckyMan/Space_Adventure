using System;

public class Inventory
{
    public static int GoldAmount;
    public static int PotatoAmount;
    public static int UnObtainiumAmount;
    public static void ShowInventory()      //displays current inventory.
    {
        Console.WriteLine("\n\nYour Inventory Contains : "); //TODO: INVENTORY - Replace {name} to call Player's username
        Console.WriteLine($"\t{GoldAmount} Gold");
        Console.WriteLine($"\t{PotatoAmount} Potatos");
        Console.WriteLine($"\t{UnObtainiumAmount} UnObtainium");
        //TODO: INVENTORY - Add more items here and add Methods
    }
    public static void Gold(int itemAmount)
    {
        if (GoldAmount + itemAmount < 0)      //Doesn't allow inventory to go negative
        {
            Console.WriteLine($"{GoldAmount} Gold  {itemAmount}");
            Console.WriteLine("Not Enough Gold!");
        }
        else if (itemAmount >= 0)                 //adding
        {
            Console.WriteLine($"{GoldAmount} Gold  +{itemAmount}");
            GoldAmount += itemAmount;
        }
        else                                    //substracting
        {
            Console.WriteLine($"{GoldAmount} Gold  {itemAmount}");
            GoldAmount += itemAmount;
        }
    }
    public static void Potato(int itemAmount)
    {
        if (PotatoAmount + itemAmount < 0)      //Doesn't allow inventory to go negative
        {
            Console.WriteLine($"{PotatoAmount} Potatos  {itemAmount}");
            Console.WriteLine("Not Enough Potatos!");
        }
        else if (itemAmount >= 0)                 //adding
        {
            Console.WriteLine($"{PotatoAmount} Potatos  +{itemAmount}");
            PotatoAmount += itemAmount;
        }
        else                                    //substracting
        {
            Console.WriteLine($"{PotatoAmount} Potatos  {itemAmount}");
            PotatoAmount += itemAmount;
        }

    }
    public static void UnObtainium(int itemAmount)
    {
        if (UnObtainiumAmount + itemAmount < 0)      //Doesn't allow inventory to go negative
        {
            Console.WriteLine($"{UnObtainiumAmount} UnObtainium  {itemAmount}");
            Console.WriteLine("Not Enough UnObtainium!");
        }
        else if (itemAmount >= 0)                 //adding
        {
            Console.WriteLine($"{UnObtainiumAmount} UnObtainium  +{itemAmount}");
            UnObtainiumAmount += itemAmount;
        }
        else                                    //substracting
        {
            Console.WriteLine($"{UnObtainiumAmount} UnObtainium  {itemAmount}");
            UnObtainiumAmount += itemAmount;
        }

    }
}
