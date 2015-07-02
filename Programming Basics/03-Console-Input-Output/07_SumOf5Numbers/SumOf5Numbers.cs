using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Write 5 numbers (seaprated by space): ");
        string numbersStr = Console.ReadLine();
        string[] strNumbers = numbersStr.Split(' ');

        if (strNumbers.Length == 5)
        {
            double[] intNumbers = new double[5];
            double numbers;

            for (int i = 0; i < strNumbers.Length; i++)
            {
                if (double.TryParse(strNumbers[i], out numbers))
                {
                    intNumbers[i] = double.Parse(strNumbers[i]);
                }
            }

            double sum = 0.0;

            for (int j = 0; j < intNumbers.Length; j++)
            {
                sum += intNumbers[j];
            }

            Console.WriteLine(sum);
        }

    }
}
