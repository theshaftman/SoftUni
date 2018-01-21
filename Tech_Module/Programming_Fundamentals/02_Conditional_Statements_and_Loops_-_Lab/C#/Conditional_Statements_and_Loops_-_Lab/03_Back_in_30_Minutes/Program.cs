using System;

namespace _03_Back_in_30_Minutes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;

            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
