using System;

class MagicCarNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] letters = { "A", "B", "C", "E", "H", "K", "M", "P", "T", "X" };
        int length = 0;

        for (int a = 0; a < 10; a++)
        {
            for (int b = 0; b < 10; b++)
            {
                for (int c = 0; c < 10; c++)
                {
                    for (int d = 0; d < 10; d++)
                    {
                        for (int e = 0; e < letters.Length; e++)
                        {
                            string endA = letters[e];

                            for (int f = 0; f < letters.Length; f++)
                            {
                                string endB = letters[f];

                                int res = 40 + a + b + c + d + GetWidth(endA) + GetWidth(endB);
                                
                                if (res == n)
                                {
                                    if (Check(a, b, c, d))
                                    {
                                        //Console.WriteLine("CA" + a.ToString() + b.ToString() +
                                        //    c.ToString() + d.ToString() + endA + endB);
                                        length++;
                                    }                                    
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(length);
    }

    private static int GetWidth(string str)
    {
        int result = 0;

        switch (str)
        {
            case "A": result = 10; break;
            case "B": result = 20; break;
            case "C": result = 30; break;
            case "E": result = 50; break;
            case "H": result = 80; break;
            case "K": result = 110; break;
            case "M": result = 130; break;
            case "P": result = 160; break;
            case "T": result = 200; break;
            case "X": result = 240; break;
        }

        return result;
    }

    private static bool Check(int a, int b, int c, int d)
    {
        if (a == b && b == c && c == d)
        {
            return true;
        }
        else if (a == b && b == c)
        {
            return true;
        }
        else if (b == c && c == d)
        {
            return true;
        }
        else if (a == b && c == d)
        {
            return true;
        }
        else if (a == c && b == d)
        {
            return true;
        }
        else if (a == d && b == c)
        {
            return true;
        }

        return false;
    }
}
