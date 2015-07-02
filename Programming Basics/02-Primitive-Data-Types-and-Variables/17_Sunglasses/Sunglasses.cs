using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 3 && n <= 101)
        {
            if (n % 2 != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int glassFrame = n * 2;
                    char middle = ' ';
                    char frame = '*';
                    char lens = '/';

                    if (i == (n / 2))
                    {
                        middle = '|';
                    }
                    else if (i == 0 || i == n - 1)
                    {
                        lens = '*';
                    }

                    Console.Write(new string(frame, 1));
                    Console.Write(new string(lens, glassFrame - 2));
                    Console.Write(new string(frame, 1));
                    Console.Write(new string(middle, n));
                    Console.Write(new string(frame, 1));
                    Console.Write(new string(lens, glassFrame - 2));
                    Console.WriteLine(new string(frame, 1));
                }
            }
        }
    }
}
