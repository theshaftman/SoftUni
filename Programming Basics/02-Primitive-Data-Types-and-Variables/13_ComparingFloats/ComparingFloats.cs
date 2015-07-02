using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine(Check(5.3, 6.01));
        Console.WriteLine(Check(5.00000001, 5.00000003));
        Console.WriteLine(Check(5.00000005, 5.00000001));
        Console.WriteLine(Check(-0.0000007, 0.00000007));
        Console.WriteLine(Check(-4.999999, -4.999998));
        Console.WriteLine(Check(4.999999, 4.999998));
    }

    static bool Check(double numberA, double numberB)
    {
        long eps = 1000000;
        bool areEqual = true;

        long numA = Convert.ToInt64(numberA * eps);
        long numB = Convert.ToInt64(numberB * eps);

        if (numA != numB)
        {
            areEqual = false;
        }

        return areEqual;
    }
}
