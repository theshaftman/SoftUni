using System;

class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine(Digit());
    }

    private static string Digit()
    {
        string str = Console.ReadLine();

        switch (str)
        {
            case "0": return "zero";
            case "1": return "one";
            case "2": return "two";
            case "3": return "three";
            case "4": return "four";
            case "5": return "five";
            case "6": return "six";
            case "7": return "seven";
            case "8": return "eight";
            case "9": return "nine";
            default: return "not a digit";
        }
    }
}
