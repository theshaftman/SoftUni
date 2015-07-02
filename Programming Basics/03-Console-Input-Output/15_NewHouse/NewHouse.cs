using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char pipe = '|';
        char roof = '*';
        char space = '-';
        double diff = n / 2.0;
        int diffRows = Convert.ToInt32(Math.Round(diff, MidpointRounding.AwayFromZero));

        if (n % 2 != 0)
        {
            if (n >= 3 && n <= 101)
            {
                int k = 0;
                int begin = (n - 1) / 2;

                for (int i = 0; i < diffRows; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(new string(space, begin));
                        Console.Write(new string(roof, 1));
                        Console.WriteLine(new string(space, begin));
                    }
                    else if (i == diffRows - 1)
                    {
                        Console.WriteLine(new string(roof, n));
                    }
                    else
                    {
                        Console.Write(new string(space, begin));
                        Console.Write(new string(roof, (n - (begin * 2))));
                        Console.WriteLine(new string(space, begin));
                    }

                    k++;
                    begin--;
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write(pipe);
                    Console.Write(new string(roof, n - 2));
                    Console.WriteLine(pipe);
                }
            }
        }
    }
}
