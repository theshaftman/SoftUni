using System;

namespace _01_Passed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());
            if (mark >= 3.0)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
