using System;

class BitExchange
{
    static void Main()
    {
        Console.WriteLine(BitExchangeAdv(CheckLong()));
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

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return 0;
    }

    private static string BitExchangeAdv(long n)
    {
        long endResult = 0;
        string result = string.Empty;
        string bin = Convert.ToString(n, 2);

        if (bin.Length < 32)
        {
            bin = bin.Insert(0, new string('0', 32 - bin.Length));
        }

        int p = CheckInt();
        int q = CheckInt();
        int k = CheckInt();

        if (k > 32 || p + k > 32 || q + k > 32 || p < 0 || q < 0 || k < 0)
        {
            return "out of range";
        }
        else if (p > q)
        {
            if (q + k > p)
            {
                return "overlapping";
            }
        }
        else if (q > p)
        {
            if (p + k > q)
            {
                return "overlapping";
            }
        }
        
        result = bin.Substring(0, bin.Length - Math.Max(p, q) - k) + 
            bin.Substring(bin.Length - Math.Min(p, q) - k, k) +
            bin.Substring(bin.Length - Math.Max(p, q), bin.Length - 
                (bin.Length - Math.Max(p, q)) - Math.Min(p, q) - k) +
            bin.Substring(bin.Length - Math.Max(p, q) - k, k) + 
            bin.Substring(bin.Length - Math.Min(p, q), Math.Min(p, q));

        endResult = ConvertToDec(result);
        
        return endResult.ToString();
    }

    private static long ConvertToDec(string str)
    {
        long result = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '1')
            {
                result += Pow(2, str.Length - 1 - i);
            }
        }

        return result;
    }

    private static long Pow(int number, int length)
    {
        long result = 1;

        for (int i = 0; i < length; i++)
        {
            result *= number;
        }

        return result;
    }
}
