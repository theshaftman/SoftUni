using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        Console.WriteLine(ExtractBit(CheckInt(), CheckInt(), CheckInt()));
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

    private static int ExtractBit(int n, int p, int v)
    {
        string bin = string.Empty;
        string vStr = v.ToString();

        if (v == 0 || v == 1)
        {
            bin = Convert.ToString(n, 2);

            if (bin.Length < 16)
            {
                bin = bin.Insert(0, new string('0', 16 - bin.Length));
            }

            string firstPart = bin.Substring(0, 16 - ++p);
            
            string secondPart = bin.Substring(16 - ++p, 16 - 1 - firstPart.Length);

            string result = firstPart + vStr + secondPart;
            //Console.WriteLine(bin.Insert(16 ));

            return Convert.ToInt32(result, 2);
        }
        

        return -1;
    }
}
