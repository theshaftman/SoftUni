using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine(TrapezoidArea(CheckDouble(), CheckDouble(), CheckDouble()));
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

    private static double TrapezoidArea(double a, double b, double h)
    {
        double area = (a + b) * h / 2;

        return area;
    }
}
