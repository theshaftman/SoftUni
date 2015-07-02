using System;

class PrintDeckOfCards
{
    static void Main()
    {
        char clubs = '\u2663';
        char diamonds = '\u2666';
        char hearts = '\u2665';
        char spades = '\u2660';
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i < cards.Length; i++)
        {
            Console.WriteLine(cards[i] + clubs + " " + cards[i] + diamonds + " " +
                cards[i] + hearts + " " + cards[i] + spades);
        }
    }
}
