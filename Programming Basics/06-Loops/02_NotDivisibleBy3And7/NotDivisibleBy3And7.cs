using System;

class NotDivisibleBy3And7
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
            if (i % 3 != 0 && i % 7 != 0)
            {
                result += i;

                if (i < number)
                {
                    result += " ";
                }
            }
        }

        return result;
    }
}
