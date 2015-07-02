using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine(InsideCircOutsideRect(CheckDouble(), CheckDouble()) ? "yes" : "no");
    }

    private static double CheckDouble()
    {
        string str = Console.ReadLine();
        double numbers;

        if (double.TryParse(str, out numbers))
        {
            return double.Parse(str);
        }

        return 0;
    }

    private static bool InsideCircOutsideRect(double x, double y)
    {
        double r = 1.5;

        if ((y - 1.0) * (y - 1.0) + (x - 1.0) * (x - 1.0) <= r * r)
        {
            if (y > 1.0)
            {
                return true;
            }
        }

        return false;
    }
}
