using System;

class Sum3Numbers
{
    static void Main()
    {
        Console.Write("Write number A: ");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Write number B: ");
        double numB = double.Parse(Console.ReadLine());
        Console.Write("Write number C: ");
        double numC = double.Parse(Console.ReadLine());

        double sum = numA + numB + numC;
        Console.WriteLine(sum);
    }
}
