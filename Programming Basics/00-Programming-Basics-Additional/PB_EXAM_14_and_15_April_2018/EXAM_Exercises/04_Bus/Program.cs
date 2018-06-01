using System;

namespace _04_Bus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int travellersCount = int.Parse(Console.ReadLine());
            int busStopsCount = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= busStopsCount; i += 1)
            {
                int passengersOutCount = int.Parse(Console.ReadLine());
                int passengersInCount = int.Parse(Console.ReadLine());
                travellersCount -= passengersOutCount;
                travellersCount += passengersInCount;

                if (i % 2 == 0)
                {
                    travellersCount -= 2;
                }
                else
                {
                    travellersCount += 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {travellersCount}");
        }
    }
}
