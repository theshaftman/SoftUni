using System;

class ThirdDigit7
{
    static void Main()
    {
        Console.WriteLine(IsThirdDigit7());
    }

    private static bool IsThirdDigit7()
    {
        string str = Console.ReadLine();

        if (str.Length < 3)
        {
            str = str.Insert(0, new string('0', 3 - str.Length));
        }

        if (str[str.Length - 3] == '7')
        {
            return true;
        }

        return false;
    }
}