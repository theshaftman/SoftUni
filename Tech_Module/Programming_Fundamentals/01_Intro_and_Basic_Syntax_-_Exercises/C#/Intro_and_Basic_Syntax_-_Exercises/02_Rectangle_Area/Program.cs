using System;

namespace _02_Rectangle_Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal rectangleArea = width * height;
            Console.WriteLine("{0:F2}", rectangleArea);
        }
    }
}
