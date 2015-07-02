using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine(BitExchange(CheckLong()));
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

    private static long BitExchange(long n)
    {
        if (n > 0)
        {
            string bin = Convert.ToString(n, 2);
            string resultBin = string.Empty;

            if (bin.Length < 32)
            {
                bin = bin.Insert(0, new string('0', 32 - bin.Length));
            }

            resultBin = bin.Substring(0, 5) + bin.Substring(26, 3) + 
                bin.Substring(8, 18) + bin.Substring(5, 3) + bin.Substring(29, 3);

            return ConvertToDec(resultBin);
        }

        return 0;
    }

    private static long ConvertToDec(string str)
    {
        long sum = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '1')
            {
                sum += Pow(2, str.Length - i - 1);
            }
        }

        return sum;
    }

    private static long Pow(int num, int length)
    {
        long result = 1;

        for (int i = 0; i < length; i++)
        {
            result *= num;
        }

        return result;
    }
}
