using System;
using System.IO;

public class Charector_Creation
{


    public static void Gender()
    {
        int correct = 0;
        string gender;

        do
        {
            Console.Clear();
            Console.WriteLine("Please choose a gender below:");
            Console.Write("Male / Female : ");
            gender = Console.ReadLine().ToUpper();
            if (gender == "MALE" || gender == "FEMALE")
            {
                correct = 1;
            }
            else { }
        } while (correct == 0);
        correct = 0;
    }

}