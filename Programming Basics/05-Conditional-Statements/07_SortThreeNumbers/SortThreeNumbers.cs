using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine(SortNumbers());
    }

    private static string SortNumbers()
    {
        double numA = CheckDouble();
        double numB = CheckDouble();
        double numC = CheckDouble();
        double biggest = 0.0;
        double second = 0.0;
        double third = 0.0;

        if (numA >= numB && numA >= numC)
        {
            biggest = numA;

            if (numB >= numC)
            {
                second = numB;
                third = numC;
            }
            else
            {
                second = numC;
                third = numB;
            }
        }
        else if (numB >= numC)
        {
            biggest = numB;

            if (numA >= numC)
            {
                second = numA;
                third = numC;
            }
            else
            {
                second = numC;
                third = numA;
            }
        }
        else
        {
            biggest = numC;

            if (numA >= numB)
            {
                second = numA;
                third = numB;
            }
            else
            {
                second = numB;
                third = numA;
            }
        }

        return biggest.ToString() + " " + second.ToString() + " " + third.ToString();
    }

    private static double CheckDouble()
    {
        string str = Console.ReadLine();
        double numbers;

        if (double.TryParse(str, out numbers))
        {
            return double.Parse(str);
        }

        return 0;
    }
}
