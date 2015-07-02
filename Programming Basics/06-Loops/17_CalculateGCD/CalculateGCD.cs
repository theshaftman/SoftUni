using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine(GCD(CheckInt(), CheckInt()));
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

    private static int GCD(int a, int b)
    {
        if (a != 0 && b != 0)
        {
            int gcd = 0;

            if (a < 0)
            {
                a -= (2 * a);
            }
            else if (b < 0)
            {
                b -= (2 * b);
            }

            for (int i = 1; i <= Math.Min(a, b); i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }

            return gcd;
        }

        return 0;
    }
}
