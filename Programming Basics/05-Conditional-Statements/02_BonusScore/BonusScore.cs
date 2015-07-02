using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine(Bonus());
    }

    private static string Bonus()
    {
        int n = CheckInt();
        string result = string.Empty;

        switch (n)
        {
            case 1:
            case 2:
            case 3: result = Convert.ToString(n * 10); break;
            case 4:
            case 5:
            case 6: result = Convert.ToString(n * 100); break;
            case 7:
            case 8:
            case 9: result = Convert.ToString(n * 1000); break;
            default: result = "invalid score"; break;
        }

        return result;
    }

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return 0;
    }
}
