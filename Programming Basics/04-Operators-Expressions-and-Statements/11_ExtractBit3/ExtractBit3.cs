using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine(ExtractBit(CheckInt()));
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

    private static string ExtractBit(int n)
    {
        string bin = Convert.ToString(n, 2);

        if (bin.Length < 16)
        {
            bin = bin.Insert(0, new string('0', 16 - bin.Length));
        }

        return bin[16 - 4].ToString();
    }
}
