using System;
using System.Linq;

namespace _10_Pairs_by_Difference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum = int.Parse(Console.ReadLine());

            int totalPairs = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if ((Math.Max(array[i], array[j]) - Math.Min(array[i], array[j])).Equals(sum))
                    {
                        totalPairs += 1;
                    }
                }
            }
            Console.WriteLine(totalPairs);
        }
    }
}
