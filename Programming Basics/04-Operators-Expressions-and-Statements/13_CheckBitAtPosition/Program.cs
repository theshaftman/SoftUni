using System;

class ExtractBitAtPosition
{
    static void Main()
    {
        Console.WriteLine(ExtractBit(CheckInt(), CheckInt()));
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

    private static bool ExtractBit(int n, int p)
    {
        string bin = Convert.ToString(n, 2);

        if (bin.Length < 16)
        {
            bin = bin.Insert(0, new string('0', 16 - bin.Length));
        }

        if (bin[16 - ++p] == '1') 
        {
            return true;
        }

        return false;
    }
}
