using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Print();
    }

    private static void Print()
    {
        string str = Console.ReadLine();
        string[] numbers = str.Split(' ');

        if (numbers.Length == 2)
        {
            int aVal = int.Parse(numbers[0]);
            int bVal = int.Parse(numbers[1]);

            for (int a = 0; a < aVal; a++)
            {
                string first = ((char)(a + 97)).ToString();
                string third = ((char)(a + 97)).ToString();

                for (int b = 0, ind = a; b < bVal; b++, ind++)
                {
                    string second = ((char)(ind + 97)).ToString();
                    
                    Console.Write(first + second + third);

                    if (b < bVal - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
