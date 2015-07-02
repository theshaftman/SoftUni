using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine(CountRectangle(CheckIfDouble(), CheckIfDouble()));
    }

    private static double CheckIfDouble()
    {
        string str = Console.ReadLine();
        double numbers;

        if (double.TryParse(str, out numbers))
        {
            return double.Parse(str);
        }

        return 0;
    }

    private static string CountRectangle(double numA, double numB)
    {
        double area = numA * numB;
        double perimeter = (numA + numB) * 2;
        string result = "Perimeter = " + perimeter + Environment.NewLine + "Area = " + area;

        return result;
    }
}
