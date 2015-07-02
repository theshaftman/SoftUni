using System;

class Volleyball
{
    static void Main()
    {
        Console.WriteLine(VolleyBallPlayDays());
    }

    private static string VolleyBallPlayDays()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine()); // holidays in year
        int h = int.Parse(Console.ReadLine()); // weekends in hometown
        double sum = 0.0;
        
        sum = h + ((48.0 - h) * 3.0 / 4.0) + (p * 2.0 / 3.0);

        if (year == "leap")
        {
            sum += (15.0 / 100.0) * sum;
        }

        string result = sum.ToString().Substring(0, sum.ToString().IndexOf('.'));     

        return result;
    }
}
