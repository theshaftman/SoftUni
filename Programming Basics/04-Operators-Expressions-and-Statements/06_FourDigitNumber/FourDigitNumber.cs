using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine(FourDigitCounts(CheckIfFourNumbered()));
    }

    private static string CheckIfFourNumbered()
    {
        string str = Console.ReadLine();
        int numbers;

        if (str.Length == 4)
        {
            if (int.TryParse(str, out numbers))
	        {
                return str;
	        }
        }

        return "0000";
    }

    private static string FourDigitCounts(string numberStr)
    {
        char[] numberParts = numberStr.ToCharArray();
        int sum = 0;

        for (int i = 0; i < numberParts.Length; i++)
        {
            sum += int.Parse(numberParts[i].ToString());
        }

        string reversed = numberParts[3].ToString() + numberParts[2].ToString() +
            numberParts[1].ToString() + numberParts[0].ToString();
        string dabc = numberParts[3].ToString() + numberParts[0].ToString() +
            numberParts[1].ToString() + numberParts[2].ToString();
        string acbd = numberParts[0].ToString() + numberParts[2].ToString() +
            numberParts[1].ToString() + numberParts[3].ToString();

        return "Sum of digits = " + sum.ToString() + Environment.NewLine +
            "Reversed (dcba) = " + reversed + Environment.NewLine +
            "Last digit in front (dabc) = " + dabc + Environment.NewLine +
            "(acbd) = " + acbd;
    }
}
