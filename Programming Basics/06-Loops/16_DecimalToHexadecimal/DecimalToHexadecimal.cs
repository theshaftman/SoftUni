using System;

class DecimalToHexadecimal
{
    private static string[] hexNumbers = { "0", "1", "2", "3", "4",
                                         "5", "6", "7", "8", "9",
                                         "A", "B", "C", "D", "E", "F" };
    static void Main()
    {
        Console.WriteLine(ToHexadecimal(CheckLong()));
    }

    private static long CheckLong()
    {
        string str = Console.ReadLine();
        long numbers;

        if (long.TryParse(str, out numbers))
        {
            return long.Parse(str);
        }

        return 0;
    }

    private static string ToHexadecimal(long dec)
    {
        string result = string.Empty;

        while (dec >= 1)
        {
            if (dec < 1)
            {
                break;
            }

            long diff = (dec % 16);
            result += hexNumbers[diff];
            dec = dec / 16;
        }

        return Reverse(result);
    }

    private static string Reverse(string str)
    {
        string result = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i].ToString();
        }

        return result;
    }
}
