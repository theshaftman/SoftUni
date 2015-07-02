using System;

class ExamSchedule
{
    static void Main()
    {
        Console.WriteLine(Schedule());
    }

    private static string Schedule()
    {
        int hours = CheckInt();
        int minutes = CheckInt();
        string partOfDay = Console.ReadLine();
        int addHours = CheckInt();
        int addMinutes = CheckInt();
        string result = string.Empty;

        if (hours >= 0 && hours <= 12)
        {
            if (minutes >= 0 && minutes <= 59)
            {
                if (partOfDay == "PM")
                {
                    hours += 12;
                }
                else if (partOfDay != "AM")
                {
                    return "Error!";
                }

                DateTime time = new DateTime(1, 1, 1, hours, minutes, 0);
                time = time.AddHours(addHours).AddMinutes(addMinutes);
                string format = "hh:mm:tt";

                result = time.ToString(format);
            }            
        }

        return result;
    }

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return -1;
    }
}
