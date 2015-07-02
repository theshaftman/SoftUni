using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine(ExchangeIfGreat());
    }

    private static string ExchangeIfGreat()
    {
        double numA = CheckDouble();
        double numB = CheckDouble();

        if (numA > numB)
        {
            double temp = numA;
            numA = numB;
            numB = temp;
        }

        return numA + " " + numB;
    }

    private static double CheckDouble()
    {
        string str = Console.ReadLine();
        double numbers;

        if (double.TryParse(str, out numbers))
        {
            return double.Parse(str);
        }

        return 0.0;
    }
}
