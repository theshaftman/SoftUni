using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine(ToDecimal(CheckBin()));
    }

    private static long ToDecimal(string bin)
    {
        long dec = 0;

        for (int i = bin.Length - 1, index = 0; i >= 0; i--, index++)
        {
            if (bin[i].ToString() == "1")
            {
                dec += Convert.ToInt64(Math.Pow(2, index));
            }
        }

        return dec;
    }

    private static string CheckBin()
    {
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].ToString() != "0" && str[i].ToString() != "1")
            {
                return string.Empty;
            }
        }

        return str;
    }
}
