using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        string timeNow = now.Day.ToString() + "." +
            now.Month.ToString() + "." +
            now.Year.ToString() + " г. " +
            now.Hour.ToString() + ":" +
            now.Minute.ToString() + ":" +
            now.Second.ToString() + " ч.";

        Console.WriteLine(timeNow);
    }
}
