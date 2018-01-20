using System;

namespace _03_Miles_to_Kilometers
{
    public class Program
    {
        private const decimal MPH_TO_KMPH = 1.60934m;

        public static void Main(string[] args)
        {
            decimal mph = decimal.Parse(Console.ReadLine());
            decimal kmph = mph * Program.MPH_TO_KMPH;
            Console.WriteLine("{0:F2}", kmph);
        }
    }
}
