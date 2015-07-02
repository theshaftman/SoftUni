using System;
using System.Numerics;
using System.Text;

class TrailingZeroesInFact
{
    static void Main()
    {
        Console.WriteLine(CountZeroes(CheckInt()));
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

    private static int CountZeroes(int n)
    {
        BigInteger fact = Factorial(n);
        StringBuilder br = new StringBuilder();
        br.Append(fact.ToString());

        return Count(br);
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger prod = 1;

        for (int i = 1; i <= n; i++)
        {
            prod *= i;
        }

        return prod;
        //if (n <= 1)
        //{
        //    return 1;
        //}

        //return n * Factorial(n - 1);
    }

    private static int Count(StringBuilder br)
    {
        int count = 0;

        for (int i = br.Length - 1; i >= 0; i--)
        {
            if (br[i].ToString() == "0")
            {
                count++;
            }
            else
            {
                break;
            }
        }

        return count;
    }
}
