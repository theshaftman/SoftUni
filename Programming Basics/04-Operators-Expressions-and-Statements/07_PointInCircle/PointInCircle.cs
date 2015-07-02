using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine(InCircle(CheckDouble(), CheckDouble()));
    }

    private static double CheckDouble()
    {
        string str = Console.ReadLine();
        double numbers;

        if (double.TryParse(str, out numbers))
        {
            return double.Parse(str);
        }

        return 10.0;
    }

    private static bool InCircle(double x, double y)
    {
        double r = 2;

        if (x * x + y * y <= r * r)
        {
            return true;
        }

        return false;
    }
}
