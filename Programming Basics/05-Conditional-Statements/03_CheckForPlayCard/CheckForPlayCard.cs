using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.WriteLine(CheckCard());
    }

    private static string CheckCard()
    {
        string str = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i].ToString() == str)
            {
                return "yes";
            }
        }

        return "no";
    }
}
