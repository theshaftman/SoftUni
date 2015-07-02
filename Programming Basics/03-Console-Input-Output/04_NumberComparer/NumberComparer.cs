using System;

class NumberComparer
{
    static void Main()
    {
        try
        {
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            double greater = Math.Max(numA, numB);
            Console.WriteLine(greater);
        }
        catch (Exception) { }
    }
}
