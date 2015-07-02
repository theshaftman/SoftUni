using System;

class RandomizeNumbers1ToN
{
    static void Main()
    {
        Console.WriteLine(Randomize(CheckInt()));
    }

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return -1;
    }

    private static string Randomize(int n)
    {
        string result = string.Empty;

        if (n >= 1)
        {
            int[] arr = new int[n];
            Random randomGenerator = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                bool checkIt = true;

                while (checkIt)
                {
                    int num = randomGenerator.Next(1, n + 1);

                    if (Check(arr, num))
                    {
                        arr[i] = num;

                        checkIt = false;
                    }
                }
            }

            result = Value(arr);
        }
        
        return result;
    }

    private static bool Check(int[] arr, int num)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                return false;
            }
        }

        return true;
    }

    private static string Value(int[] arr)
    {
        string result = string.Empty;

        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i].ToString();

            if (i < arr.Length - 1)
            {
                result += " ";
            }
        }

        return result;
    }
}
