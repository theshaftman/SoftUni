using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine(IfDivide(CheckIfInt()));
    }

    private static int CheckIfInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return 0;
    }

    private static bool IfDivide(int number)
    {
        if (number % 7 == 0 && number % 5 == 0)
        {
            return true;
        }

        return false;
    }
}
