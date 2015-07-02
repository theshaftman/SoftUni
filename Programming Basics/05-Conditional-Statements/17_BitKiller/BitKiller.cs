using System;

class BitKiller
{
    static void Main()
    {
        Console.WriteLine(Bit());
    }

    private static string Bit()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 100 && step >= 1 && step <= 20)
        {
            string[] binArr = GetBinArr(n);
            string startResult = GetString(binArr);
            string endResult = SetString(startResult, n, step);
            string[] endToBin = SetBinArr(endResult, n);

            return Result(endToBin);
        }

        return "";
    }

    private static string[] GetBinArr(int length)
    {
        int[] arr = new int[length];
        string[] bin = new string[length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

            if (arr[i] > 255 || arr[i] < 0)
            {
                return new string[] { "" };
            }
        }

        for (int j = 0; j < bin.Length; j++)
        {
            string toBin = Convert.ToString(arr[j], 2);

            if (toBin.Length < 8)
	        {
                toBin = toBin.Insert(0, new string('0', 8 - toBin.Length));
	        }

            bin[j] = toBin;
        }

        return bin;
    }

    private static string GetString(string[] arr)
    {
        string result = string.Empty;

        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }

        return result;
    }

    private static string SetString(string str, int n, int step)
    {
        string result = string.Empty;
        int index = 1;

        for (int i = 0; i < str.Length; i++)
        {
            if (i == index)
            {
                index += step;
            }
            else
            {
                result += str[i];
            }
        }

        if (result.Length < n * 8)
        {
            result = result.Insert(result.Length, new string('0', (n * 8) - result.Length));
        }

        return result;
    }

    private static string[] SetBinArr(string result, int n)
    {
        string[] arr = new string[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = result.Substring(i * 8, 8);
        }

        return arr;
    }

    private static string Result(string[] arr)
    {
        string result = string.Empty;
        int[] dec = new int[arr.Length];
        int length = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            dec[i] = Convert.ToInt32(arr[i], 2);

            if (dec[i] != 0)
            {
                length++;
            }
        }

        for (int j = 0; j < length; j++)
        {
            result += dec[j];

            if (j < length - 1)
            {
                result += Environment.NewLine;
            }
        }

        return result;
    }
}
