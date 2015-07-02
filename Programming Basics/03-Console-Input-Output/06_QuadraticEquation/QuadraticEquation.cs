using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double result1;
        double result2;
        double isThereRoots;
        string result = string.Empty;

        if (a != 0)
        {
            isThereRoots = b * b - 4 * a * c;

            if (isThereRoots > 0)
            {
                result1 = (-b - Math.Sqrt(isThereRoots)) / (2 * a);
                result2 = (-b + Math.Sqrt(isThereRoots)) / (2 * a);
                result = "x1 = " + result1.ToString() + "; x2 = " + result2.ToString();
            }
            else if (isThereRoots == 0)
            {
                result1 = (-b) / (2 * a);
                result = "x1 = x2 = " + result1.ToString();
            }
            else if (isThereRoots < 0)
            {
                result = "no real roots";
            }
        }
        else if (b != 0)
        {
            result1 = (-c) / b;
            result = "x1 = x2 = " + result1.ToString();
        }
        else
        {
            result = "no real roots";
        }

        Console.WriteLine(result);
    }
}
