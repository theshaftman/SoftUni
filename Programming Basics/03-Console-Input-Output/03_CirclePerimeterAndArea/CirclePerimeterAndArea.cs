using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("\"r\": ");
        string rStr = Console.ReadLine();
        double numbers;
        double r = 0.0;

        if (double.TryParse(rStr, out numbers))
        {
            r = double.Parse(rStr);
        }

        double perimeter = Math.PI * r * 2;
        double area = Math.PI * r * r;

        Console.WriteLine("Perimeter = {0:F2}", perimeter);
        Console.WriteLine("Area = {0:F2}", area);
    }
}
