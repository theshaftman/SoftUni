using System;

class Arrow
{
    static void Main()
    {
        PrintArrow(CheckInt());
    }

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numebrs;

        if (int.TryParse(str, out numebrs))
        {
            return int.Parse(str);
        }

        return -1;
    }

    private static void PrintArrow(int n)
    {
        if (n >= 3 && n <= 79)
        {
            if (n % 2 != 0)
            {
                char sign = '#';
                char rest = '.';

                int rowLength = (n * 2) - 1;
                int distance = 1;
                string print = string.Empty;

                for (int i = 0; i < rowLength; i++)
                {
                    if (i == 0)
                    {
                        print = new string(rest, (rowLength - n) / 2) +
                            new string(sign, n) +
                            new string(rest, (rowLength - n) / 2);
                    }
                    else if (i > 0 && i < n - 1)
                    {
                        print = new string(rest, (rowLength - n) / 2) + sign +
                            new string(rest, n - 2) + sign +
                            new string(rest, (rowLength - n) / 2);
                    }
                    else if (i > n - 1 && i < rowLength - 1)
                    {
                        print = new string(rest, distance) + sign +
                            new string(rest, rowLength - 2 - (2 * distance)) + sign +
                            new string(rest, distance);
                        distance++;
                    }
                    else if (i == rowLength - 1)
                    {
                        print = new string(rest, distance) + sign +
                            new string(rest, distance);
                    }
                    else
                    {
                        print = new string(sign, (rowLength - (n - 2)) / 2) + 
                            new string(rest, n - 2) +
                            new string(sign, (rowLength - (n - 2)) / 2);
                    }

                    Console.WriteLine(print);
                }
            }
        }
    }
}
