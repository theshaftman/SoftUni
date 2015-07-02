using System;

class TheExplorer
{
    static void Main()
    {
        Console.WriteLine(PrintDiamond(CheckInt()));
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

    private static string PrintDiamond(int n)
    {
        string result = string.Empty;
        char diamond = '*';
        char surround = '-';
        int add = 1;
        int secondAdd = 1;

        if (n % 2 != 0)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    result += new string(surround, n / 2) + diamond + new string(surround, n / 2);
                }
                else if (i == n / 2)
                {
                    result += diamond + new string(surround, n - 2) + diamond;
                }
                else if (i < n / 2)
                {
                    result += new string(surround, (n / 2) - i) + diamond +
                        new string(surround, add) + diamond + new string(surround, (n / 2) - i);
                    add += 2;
                }
                else
                {
                    add -= 2;
                    result += new string(surround, secondAdd) + diamond +
                        new string(surround, add) + diamond + new string(surround, secondAdd);
                    secondAdd++;
                }

                result += Environment.NewLine;
            }
        }

        return result;
    }
}
