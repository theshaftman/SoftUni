using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine(Calculate(CheckInt()));
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

    private static BigInteger Calculate(int n)
    {
        BigInteger sum = -1;

        if (n >= 0 && n <= 100)
        {
            sum = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        }

        return sum;
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger product = 1;

        for (int i = 1; i <= n; i++)
        {
            product *= i;
        }

        return product;
    }
}
