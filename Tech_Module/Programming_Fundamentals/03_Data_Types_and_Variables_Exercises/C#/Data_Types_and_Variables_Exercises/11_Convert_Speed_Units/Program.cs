using System;

namespace _11_Convert_Speed_Units
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double secondsConverted = (((hours * 60) * 60) + minutes * 60 + seconds);
            float metersPerHour = ((float)meters / (float)secondsConverted);
            double hourTime = (hours + ((double)minutes / 60) + ((double)((double)seconds / 60) / 60));
            float kmPerHour = (((float)meters / 1000) / (float)hourTime);
            float mPerHour = (float)((double)meters / (double)1609) / (float)hourTime;

            Console.WriteLine(metersPerHour);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(mPerHour);
        }
    }
}
