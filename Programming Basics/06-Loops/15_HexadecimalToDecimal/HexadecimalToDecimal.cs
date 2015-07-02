using System;

class HexadecimalToDecimal
{
    private static string[] hexNumbers = {"0", "1", "2", "3", "4",
                                         "5", "6", "7", "8", "9",
                                         "A", "B", "C", "D", "E", "F"};

    static void Main()
    {
        Console.WriteLine(ToDecimal(CheckHex()));
    }

    private static string CheckHex()
    {
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            if (!Check(str[i].ToString().ToUpper()))
            {
                return string.Empty;
            }
        }
        
        return str.ToUpper();
    }

    private static bool Check(string str)
    {
        for (int i = 0; i < hexNumbers.Length; i++)
        {
            if (hexNumbers[i] == str)
            {
                return true;
            }
        }

        return false;
    }

    private static long ToDecimal(string hex)
    {
        hex = Reverse(hex);
        long result = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            result += CheckNum(hex[i].ToString()) * Convert.ToInt64(Math.Pow(16, i));
        }

        return result;
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

    private static int CheckNum(string str)
    {
        for (int i = 0; i < hexNumbers.Length; i++)
        {
            if (hexNumbers[i].ToString() == str)
            {
                return i;
            }
        }

        return 0;
    }
}
