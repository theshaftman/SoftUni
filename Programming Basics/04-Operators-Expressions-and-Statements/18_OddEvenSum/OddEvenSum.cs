using System;

class OddEvenSum
{
    static void Main()
    {
        Console.WriteLine(OddEvenSummator());
    }

    private static string OddEvenSummator()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < n; i++)
        {
            oddSum += int.Parse(Console.ReadLine());
            evenSum += int.Parse(Console.ReadLine());
        }

        string result = string.Empty;

        if (oddSum == evenSum)
        {
            result = "Yes, sum = " + oddSum;
        }
        else if (oddSum > evenSum)
        {
            result = "No, diff = " + (oddSum - evenSum);
        }
        else
        {
            result = "No, diff = " + (evenSum - oddSum);
        }

        return result;
    }
}
