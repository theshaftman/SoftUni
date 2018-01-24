using System;

namespace _06_Interval_of_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            for (int i = Math.Min(numberA, numberB); i <= Math.Max(numberA, numberB); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
