using System;

class Pairs
{
    static void Main()
    {
        Console.WriteLine(FindPairs());
    }

    private static string FindPairs()
    {
        string str = Console.ReadLine();
        string[] arrStr = str.Split(' ');

        if (arrStr.Length % 2 == 0)
	    {
            int[] arr = IntArr(arrStr);
            int[] sums = ArrSums(arr);

            return EqualValues(sums);
	    }

        return "Write equal 2*N elements!";
    }

    private static int[] IntArr(string[] arrStr)
    {
        int[] arr = new int[arrStr.Length];
        int numbers;

        for (int i = 0; i < arr.Length; i++)
        {
            if (int.TryParse(arrStr[i], out numbers))
            {
                arr[i] = int.Parse(arrStr[i]);
            }
            else
            {
                return new int[] { -1 };
            }
        }

        return arr;
    }

    private static int[] ArrSums(int[] arr)
    {
        int[] sums = new int[arr.Length / 2];
        int sum = 0;
        int i, j;

        for (i = 0, j = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0 && i != 0)
            {
                sums[j] = sum;
                sum = 0;

                j++;
            }

            sum += arr[i];
        }

        sums[j] = sum;

        return sums;
    }

    private static string EqualValues(int[] arr)
    {
        int sum = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != sum)
            {
                return "No, maxdiff=" + Diff(arr);
            }
        }

        return "Yes, value=" + sum.ToString();
    }

    private static string Diff(int[] arr)
    {
        int max = arr[0];
        int min = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            min = Math.Min(min, arr[i]);
            max = Math.Max(max, arr[i]);
        }

        return (max - min).ToString();
    }
}
