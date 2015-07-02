using System;

class NumbersToN
{
    static void Main()
    {
        Console.Write("Enter \"N\" number: ");
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            int n = int.Parse(str);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
