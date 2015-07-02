using System;

class SortingNumbers
{
    static void Main()
    {
        SortArr(CheckInt());
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

    private static void SortArr(int n)
    {
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = CheckInt();
        }

        Print(Sort(arr));
    }

    private static int[] Sort(int[] arr)
    {
        Array.Sort(arr);

        return arr;
    }

    private static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
