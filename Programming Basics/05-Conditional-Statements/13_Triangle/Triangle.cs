using System;

class Triangle
{
    static void Main()
    {
        Console.WriteLine(CheckIfTriangle());
    }

    private static string CheckIfTriangle()
    {
        string result = string.Empty;

        int x1 = CheckInt();
        int y1 = CheckInt();
        int x2 = CheckInt();
        int y2 = CheckInt();
        int x3 = CheckInt();
        int y3 = CheckInt();

        double lengthAtoB = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        double lengthBtoC = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
        double lengthCtoA = Math.Sqrt(((x3 - x1) * (x3 - x1)) + ((y3 - y1) * (y3 - y1)));

        if (CanTriangle(lengthAtoB, lengthBtoC, lengthCtoA))
        {
            result = "yes" + Environment.NewLine;

            double p = (lengthAtoB + lengthBtoC + lengthCtoA) / 2.0;
            double area = Math.Sqrt(p * (p - lengthAtoB) * (p - lengthBtoC) * (p - lengthCtoA));
            
            result += Check(Math.Round(area, 2));
        }
        else
        {
            result = "no" + Environment.NewLine + Check(Math.Round(lengthAtoB, 2));
        }

        return result;
    }

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            if (int.Parse(str) >= -10000 && int.Parse(str) <= 10000)
            {
                return int.Parse(str);
            }
        }

        return 0;
    }

    private static bool CanTriangle(double a, double b, double c) 
    {
        if (a + b <= c || b + c <= a || a + c <= b)
        {
            return false;
        }

        return true;
    }

    private static string Check(double n)
    {
        string str = n.ToString();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '.')
            {
                return n.ToString();
            }
        }

        return str + ".00";
    }
}
