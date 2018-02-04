using System;

namespace _12_Rectangle_Properties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = (width + height) * 2.0;
            double area = width * height;
            double diagonal = Math.Sqrt((width * width) + (height * height));
            Console.WriteLine("{1}{0}{2}{0}{3}", Environment.NewLine, perimeter, area, diagonal);
        }
    }
}
