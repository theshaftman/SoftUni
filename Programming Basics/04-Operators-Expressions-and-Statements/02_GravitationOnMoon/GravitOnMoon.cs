using System;

class GravitOnMoon
{
    static void Main()
    {
        Console.WriteLine(OnMoon(CheckDouble()));
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

    private static double OnMoon(double onEarth)
    {
        return onEarth * (17.0 / 100.0);
    }
}
