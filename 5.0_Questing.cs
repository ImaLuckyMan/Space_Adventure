using System;

public class Class1
{
    int correct = 0;
    int questRewardGold = 0;
    int questRewardExp = 0;
    int playerQuestGoal;

    string Input;
    string playerQuest;
    string questAccepted;
    string playerQuestEnemy;

	public Class1()
	{
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
        Console.ReadLine();
    }
}
