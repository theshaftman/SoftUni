using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine(NumbersTo(CheckInt()));
    }

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return -1;
    }

    private static string NumbersTo(int number)
    {
        string result = string.Empty;

        for (int i = 1; i <= number; i++)
        {
            result += i;

            if (i < number)
            {
                result += " ";
            }
        }

        return result;
    }
}
