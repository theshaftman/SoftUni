using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine(CheckOddOrEven(CheckIfInt()));
    }

    private static int CheckIfInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return 0;
    }

    private static bool CheckOddOrEven(int n)
    {
        if (n % 2 == 0)
        {
            return false;
        }

        return true;
    }
}
