using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");

        Console.WriteLine(IsBeerTime());
    }

    private static string IsBeerTime()
    {
        DateTime time = DateTime.Parse(Console.ReadLine());

        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");

        if (time >= startTime || time <= endTime)
        {
            return "beer time";
        }

        return "non-beer time";
    }
}
