using System;
using System.Linq;

class MinMaxSumAvg
{
    static void Main()
    {
        Console.WriteLine(FindThem(CheckInt()));
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

    private static string FindThem(int n)
    {
        string result = string.Empty;
        
        if (n > 0)
        {
            int[] numbers = new int[n];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = CheckInt();
                sum += numbers[i];
            }

            int min = numbers.Min();
            int max = numbers.Max();
            string avg = Math.Round(numbers.Average(), 2).ToString("0.00");

            result = "min = " + min + Environment.NewLine +
                "max = " + max + Environment.NewLine +
                "sum = " + sum + Environment.NewLine +
                "avg = " + avg;
        }

        return result;
    }
}
