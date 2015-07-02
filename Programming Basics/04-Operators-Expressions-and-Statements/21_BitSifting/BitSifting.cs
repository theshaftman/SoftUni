using System;
using System.Text;

class BitSifting
{
    static void Main()
    {
        Console.WriteLine(BitSift());
    }

    private static int BitSift()
    {
        // max possible ulong = 18446744073709551615

        ulong n = IfUlong();
        string bin = ConvToBin(n);
        int anotherNumbers = int.Parse(Console.ReadLine());
        int ones = 0;

        if (anotherNumbers > 0)
        {
            string[] binArr = new string[anotherNumbers + 1];

            if (bin.Length < 64)
            {
                bin = bin.Insert(0, new string('0', 64 - bin.Length));
            }

            binArr[0] = bin;

            for (int i = 1; i < binArr.Length; i++)
            {
                string str = ConvToBin(IfUlong());

                if (str.Length < 64)
                {
                    str = str.Insert(0, new string('0', 64 - str.Length));
                }

                binArr[i] = str;
            }

            ones = Counter(binArr);
        }
        else
        {
            ones = CountOnes(bin);
        }
        
        return ones;
    }

    private static int Counter(string[] arr)
    {
        int result = 0;

        for (int i = 0; i < arr[0].Length; i++)
        {
            if (arr[0][i] == '1')
            {
                int counter = 0;

                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j][i] == '0')
                    {
                        counter++;
                    }
                }

                if (counter == arr.Length - 1)
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static void Print(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    private static ulong IfUlong()
    {
        string str = Console.ReadLine();
        ulong numbers;

        if (ulong.TryParse(str, out numbers))
        {
            return ulong.Parse(str);
        }

        return 0;
    }

    private static string ConvToBin(ulong value)
    {
        if (value == 0) 
        { 
            return "0"; 
        }

        StringBuilder b = new StringBuilder();

        while (value != 0)
        {
            b.Insert(0, ((value & 1) == 1) ? '1' : '0');
            value >>= 1;
        }

        return b.ToString();
    }

    private static int CountOnes(string str)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '1')
            {
                count++;
            }
        }

        return count;
    }
}
