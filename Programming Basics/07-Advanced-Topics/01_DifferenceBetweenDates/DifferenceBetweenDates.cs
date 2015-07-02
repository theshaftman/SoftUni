using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        Dates();
    }

    private static void Dates()
    {
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();

        DateTime dateTime;
        string format = "d.MM.yyyy";

        if (DateTime.TryParseExact(startDate, format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime))
        {
            if (DateTime.TryParseExact(endDate, format, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out dateTime))
            {
                DateTime start = DateTime.ParseExact(startDate, format,
                        CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime end = DateTime.ParseExact(endDate, format,
                    CultureInfo.InvariantCulture, DateTimeStyles.None);

                TimeSpan diff = end - start;

                Console.WriteLine(diff.Days);
            }            
        }
    }
}
