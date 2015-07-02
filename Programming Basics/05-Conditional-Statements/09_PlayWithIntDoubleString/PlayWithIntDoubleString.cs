using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Play();
    }

    private static void Play()
    {
        Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string
");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": Console.WriteLine(IntPlay()); break;
            case "2": Console.WriteLine(DoublePlay()); break;
            case "3": Console.WriteLine(StringPlay()); break;
            default:
                {
                    Console.WriteLine("Try again");
                    Play();
                } 
                break;
        }
    }

    private static int IntPlay()
    {
        string str = Console.ReadLine();
        int doubleNumber;

        if (int.TryParse(str, out doubleNumber))
        {
            return int.Parse(str) + 1;
        }

        return -1;
    }

    private static double DoublePlay()
    {
        string str = Console.ReadLine();
        double doubleNumber;

        if (double.TryParse(str, out doubleNumber))
        {
            return double.Parse(str) + 1.0;
        }

        return -1;
    }

    private static string StringPlay()
    {
        string str = Console.ReadLine();

        return str + "*";
    }
}
