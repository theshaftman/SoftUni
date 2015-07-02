using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine(ToBin(CheckLong()));
    }

    private static long CheckLong()
    {
        string str = Console.ReadLine();
        long numbers;

        if (long.TryParse(str, out numbers))
        {
            return long.Parse(str);
        }

        return -1;
    }

    private static string ToBin(long dec)
    {
        string result = string.Empty;

        if (dec == 0)
        {
            return "0";
        }

        while (true)
        {
            if (dec < 1)
            {
                return Reverse(result);
            }

            long diff = dec % 2;
            result += (dec % 2).ToString();

            dec = dec / 2;
        }
    }

    private static string Reverse(string str)
    {
        string result = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }

        return result;
    }
}
