using System;

namespace _04_Hotel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            if (month.Equals("May"))
            {
                if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {((50.0 * (double)nightsCount) * 0.95):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {(50.0 * (double)nightsCount):F2} lv.");
                }
                Console.WriteLine($"Double: {(65.0 * (double)nightsCount):F2} lv.");
                Console.WriteLine($"Suite: {(75.0 * (double)nightsCount):F2} lv.");
            }
            else if (month.Equals("June"))
            {
                Console.WriteLine($"Studio: {(60.0 * (double)nightsCount):F2} lv.");
                if (nightsCount > 14)
                {
                    Console.WriteLine($"Double: {((72.0 * (double)nightsCount) * 0.90):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Double: {(72.0 * (double)nightsCount):F2} lv.");
                }
                Console.WriteLine($"Suite: {(82.0 * (double)nightsCount):F2} lv.");
            }
            else if (month.Equals("July") || month.Equals("August") || month.Equals("December"))
            {
                Console.WriteLine($"Studio: {(68.0 * (double)nightsCount):F2} lv.");
                Console.WriteLine($"Double: {(77.0 * (double)nightsCount):F2} lv.");
                if (nightsCount > 14)
                {
                    Console.WriteLine($"Suite: {((89.0 * (double)nightsCount) * 0.85):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Suite: {(89.0 * (double)nightsCount):F2} lv.");
                }
            }
            else if (month.Equals("September"))
            {
                if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {(60.0 * (double)(nightsCount - 1)):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {(60.0 * (double)nightsCount):F2} lv.");
                }
                if (nightsCount > 14)
                {
                    Console.WriteLine($"Double: {((72.0 * (double)nightsCount) * 0.9):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Double: {(72.0 * (double)nightsCount):F2} lv.");
                }
                Console.WriteLine($"Suite: {(82.0 * (double)nightsCount):F2} lv.");
            }
            else if (month.Equals("October"))
            {
                if (nightsCount > 7)
                {
                    Console.WriteLine($"Studio: {((50.0 * (double)(nightsCount - 1)) * 0.95):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {(50.0 * (double)nightsCount):F2} lv.");
                }
                Console.WriteLine($"Double: {(65.0 * (double)nightsCount):F2} lv.");
                Console.WriteLine($"Suite: {(75.0 * (double)nightsCount):F2} lv.");
            }
        }
    }
}
