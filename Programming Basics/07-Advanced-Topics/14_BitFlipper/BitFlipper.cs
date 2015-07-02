using System;

class BitFlipper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string bin = ToBin(number);

        if (bin.Length < 64)
        {
            bin = bin.Insert(0, new string('0', 64 - bin.Length));
        }

        char[] binArr = bin.ToCharArray();
        int index = 0;

        while (index < 64 - 2)
        {
            char getChar = binArr[index];

            if (binArr[index + 1] == getChar)
            {
                if (binArr[index + 2] == getChar)
                {
                    if (getChar == '0')
                    {
                        binArr[index] = '1';
                        binArr[index + 1] = '1';
                        binArr[index + 2] = '1';
                    }
                    else
                    {
                        binArr[index] = '0';
                        binArr[index + 1] = '0';
                        binArr[index + 2] = '0';
                    }

                    index += 3;
                    continue;
                }
            }

            index++;
        }

        bin = ToStr(binArr);
        Console.WriteLine(ToDecimal(bin));

        //Console.WriteLine(bin);
    }

    private static string ToBin(ulong n)
    {
        string result = string.Empty;

        if (n == 0)
        {
            return "0";
        }

        while (true)
        {
            if (n < 1)
            {
                return Reverse(result);
            }

            ulong diff = n % 2;
            result += (n % 2).ToString();

            n = n / 2;
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

    private static string ToStr(char[] arr)
    {
        string result = string.Empty;

        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i].ToString();
        }

        return result;
    }

    private static ulong ToDecimal(string bin)
    {
        ulong dec = 0;

        for (int i = bin.Length - 1, index = 0; i >= 0; i--, index++)
        {
            if (bin[i].ToString() == "1")
            {
                dec += Pow(2, index);
            }
        }

        return dec;
    }

    private static ulong Pow(int n, int pow)
    {
        ulong result = 1;

        for (int i = 0; i < pow; i++)
        {
            result *= (ulong)n;
        }

        return result;
    }
}
