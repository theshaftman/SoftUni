﻿using System;

class CalculateNK
{
    static void Main()
    {
        Console.WriteLine(Calculate(CheckInt(), CheckInt()));
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

    private static int Calculate(int n, int k)
    {
        int sum = -1;

        if (k > 1 && n > k && n < 100)
        {
            sum = Factorial(n) / Factorial(k);
        }

        return sum;
    }

    private static int Factorial(int n)
    {
        int product = 1;

        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }

        return product;
    }
}
