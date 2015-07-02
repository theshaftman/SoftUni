using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intValue = null;
        double? doubleValue = null;
        Console.WriteLine("Null Int value: {0}", intValue);
        Console.WriteLine("Null Double value: {0}", doubleValue);
        Console.WriteLine();

        intValue += 7;
        doubleValue += 3.75;
        Console.WriteLine("Null Int value(+=): {0}", intValue);
        Console.WriteLine("Null Double value(+=): {0}", doubleValue);
        Console.WriteLine();

        intValue = 7;
        doubleValue = 3.75;
        Console.WriteLine("Null Int value(=): {0}", intValue);
        Console.WriteLine("Null Double value(=): {0}", doubleValue);
    }
}
