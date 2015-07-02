using System;

class LongestAreaInArray
{
    static void Main()
    {
        MakeArray(CheckInt());
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

    private static void MakeArray(int n)
    {
        string[] arr = new string[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }

        Print(FindMax(arr));
    }

    private static string[] FindMax(string[] arr)
    {
        int max = Max(arr);
        string[] result = new string[max];
        string str = MaxStr(arr);

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = str;
        }

        return result;
    }

    private static int Max(string[] arr)
    {
        int max = 1;
        int result = max;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                max++;
            }
            else
            {
                if (result < max)
                {
                    result = max;
                }

                max = 1;
            }
        }

        if (result < max)
        {
            result = max;
        }

        return result;
    }

    private static string MaxStr(string[] arr)
    {
        int max = 1;
        int check = max;
        string result = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                max++;
            }
            else
            {
                if (check < max)
                {
                    check = max;
                    result = arr[i - 1];
                }
                max = 1;
            }
        }

        if (check < max)
        {
            check = max;
            result = arr[arr.Length - 1];
        }

        return result;
    }

    private static void Print(string[] arr)
    {
        Console.WriteLine(arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
