using System;

class BitRoller
{
    static void Main()
    {
        Roller();
    }

    private static void Roller()
    {
        int n = CheckInt();
        int f = CheckInt();
        int r = CheckInt();

        if (n >= 0 && n <= 524287)
        {
            if (f >= 0 && f <= 18)
            {
                if (r >= 0 && r <= 100)
                {
                    string bin = Convert.ToString(n, 2);

                    if (bin.Length < 19)
                    {
                        bin = bin.Insert(0, new string('0', 19 - bin.Length));
                    }

                    string changeBin = ChangeBin(bin, f, r);
                    int dec = Convert.ToInt32(changeBin, 2);

                    Console.WriteLine(dec);
                }
            }
        }
    }

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return -1;
    }

    private static string ChangeBin(string str, int position, int repeated)
    {
        string result = string.Empty;
        string midResult = string.Empty;
        string variable = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (i != (str.Length - position - 1))
            {
                result += str[i];
            }
            else
	        {
                variable = str[i].ToString();
	        }
        }

        //result = Reverse(result);
        midResult = result.Substring(repeated, 18 - repeated) + result.Substring(0, repeated);
        midResult = midResult.Insert(position, variable);

        return Reverse(midResult);
    }

    private static string Reverse(string str)
    {
        string result = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }

        return result;
    }
}
