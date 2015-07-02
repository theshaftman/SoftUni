using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.WriteLine(RandomNumbers(CheckInt(), CheckInt(), CheckInt()));
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

    private static string RandomNumbers(int n, int min, int max)
    {
        Random randomGenerator = new Random();
        string result = string.Empty;

        if (max >= min)
        {
            for (int i = 0; i < n; i++)
            {
                result += randomGenerator.Next(min, max + 1).ToString();

                if (i < n - 1)
                {
                    result += " ";
                }
            }
        }
        
        return result;
    }
}
