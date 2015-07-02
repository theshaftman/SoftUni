using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Matrix();
    }

    private static void Matrix()
    {
        int n = CheckInt();

        if (n >= 1 && n <= 20)
        {
            Print(GiveValues(n));
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

    private static int[,] GiveValues(int n)
    {
        int[,] matrix = new int[n, n];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int position = row + 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = position;

                position++;
            }
        }

        return matrix;
    }

    private static void Print(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);

                if (col < matrix.GetLength(1) - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
