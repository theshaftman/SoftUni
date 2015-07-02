using System;

class TheBiggestOfThree
{
    static void Main()
    {
        Console.WriteLine(CheckTheBiggest());
    }

    private static double CheckTheBiggest()
    {
        double numA = CheckDouble();
        double numB = CheckDouble();
        double numC = CheckDouble();

        if (numA >= numB && numA >= numC)
        {
            return numA;
        }
        else if (numB >= numC)
        {
            return numB;
        }

        return numC;
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
