using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine(PrimeCheck(IntCheck()));
    }

    private static int IntCheck()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return -1;
    }

    private static bool PrimeCheck(int n)
    {
        if (n >= 2 && n <= 100)
        {
            double sqrt = Math.Sqrt(n);

            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0) 
                {
                    return false;
                }
            }

            return true;
        }

        return false;
    }
}
