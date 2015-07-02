using System;

class TheBiggestOfFive
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
        double numD = CheckDouble();
        double numE = CheckDouble();

        if (numA >= numB && numA >= numC && numA >= numD && numA >= numE)
        {
            return numA;
        }
        else if (numB >= numC && numB >= numD && numB >= numE)
        {
            return numB;
        }
        else if (numC >= numD && numC >= numE)
        {
            return numC;
        }
        else if (numD >= numE)
        {
            return numD;
        }

        return numE;
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
