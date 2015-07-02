using System;

class BitsUp
{
    static void Main()
    {
        Bits();
    }

    private static void Bits()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 100)
        {
            if (step >=1 && step <= 20)
            {
                int[] arr = new int[n];
                arr = IntArray(arr);
                string[] toBin = new string[n];
                toBin = ToBin(arr, toBin);

                string wholeStr = ArrayJoin(toBin);
                string change = ChangeAtPosition(wholeStr, step);
                toBin = ChangeToBin(toBin, change);
                
                Print(toBin);
            }
        }
    }

    private static int[] IntArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int check = int.Parse(Console.ReadLine());

            if (check >= 0 && check <= 255)
            {
                arr[i] = check;
            }
            else
            {
                break;
            }
        }

        return arr;
    }

    private static string[] ToBin(int[] decArr, string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            string bin = Convert.ToString(decArr[i], 2);

            if (bin.Length < 8)
            {
                bin = bin.Insert(0, new string('0', 8 - bin.Length));
            }

            arr[i] = bin;
        }

        return arr;
    }

    private static string ArrayJoin(string[] arr)
    {
        string result = string.Empty;

        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }

        return result;
    }

    private static string ChangeAtPosition(string str, int step)
    {
        int position = 1;
        char[] resultStr = str.ToCharArray();
        string result = string.Empty;

        while (position < str.Length)
        {
            resultStr[position] = '1';
            
            position += step;
        }

        for (int i = 0; i < resultStr.Length; i++)
        {
            result += resultStr[i].ToString();
        }

        return result;
    }

    private static string[] ChangeToBin(string[] arr, string change)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = change.Substring(i * 8, 8);
        }

        return arr;
    }

    private static void Print(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(Convert.ToInt32(arr[i], 2));
        }
    }
}
