using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Number A (0 <= number A <= 500): ");
        string numAStr = Console.ReadLine();
        Console.Write("Number B: ");
        string numBStr = Console.ReadLine();
        Console.Write("Number C: ");
        string numCStr = Console.ReadLine();
        int intNumbers;
        double doubleNumbers;

        if (int.TryParse(numAStr, out intNumbers) && 
            double.TryParse(numBStr, out doubleNumbers) &&
            double.TryParse(numCStr, out doubleNumbers))
        {
            int numA = int.Parse(numAStr);
            double numB = double.Parse(numBStr);
            double numC = double.Parse(numCStr);

            if (numA >= 0 && numA <= 500)
            {
                string hexNumA = Convert.ToString(numA, 16).ToUpper();
                string binNumA = Convert.ToString(numA, 2);

                if (binNumA.Length < 10)
                {
                    string result = new string('0', 10 - binNumA.Length);
                    result += binNumA;

                    binNumA = result;
                }

                if (int.TryParse(numBStr, out intNumbers))
                {
                    Console.WriteLine("|{0,-10}|{1}|{2,10}|{3,-10:F3}|", 
                        hexNumA, binNumA, numB, numC);
                }
                else
                {
                    Console.WriteLine("|{0,-10}|{1}|{2,10:F2}|{3,-10:F3}|", 
                        hexNumA, binNumA, numB, numC);
                }
            }
        }
    }
}
