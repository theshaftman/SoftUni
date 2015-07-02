using System;

class CalculateExpression
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

    private static string Calculate(int n, int x)
    {
        string result = string.Empty;

        if (n > 0)
        {
            double sum = 1.0;
            int pow = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(i) / Math.Pow(x, pow);

                pow++;
            }

            result = sum.ToString("N5");
        }

        return result;
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
