using System;

class JoroFootballPlayer
{
    static void Main()
    {
        int weekends = 52;
        string leapYearStr = Console.ReadLine(); // leap year check
        int leapYear = 0;

        double numberOfHolidays = double.Parse(Console.ReadLine()); // holidays
        double numberOfWeekendsHome = double.Parse(Console.ReadLine()); // weekend home

        if (numberOfHolidays >= 0 && numberOfHolidays <= 300)
        {
            if (numberOfWeekendsHome >= 0 && numberOfWeekendsHome <= weekends)
            {
                if (leapYearStr == "t") //leap year
                {
                    leapYear = 3;
                }
                else if (leapYearStr == "f") // not a leap year
                {

                }

                double weekendsPlay = (weekends - numberOfWeekendsHome) * 2 / 3;
                double plays = numberOfWeekendsHome + (0.5 * numberOfHolidays) + 
                    leapYear + weekendsPlay;

                // Console.WriteLine(weekendsPlay);

                string result = plays.ToString().Substring(0, plays.ToString().IndexOf('.', 0));
                Console.WriteLine(result);
            }
        }
    }
}
