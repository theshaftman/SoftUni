using System;

class SpiralMatrix
{
    static void Main()
    {
        Matrix(CheckInt());
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

    private static void Matrix(int n)
    {
        if (n >= 1 && n <= 20)
        {
            int[,] matrix = Evaluate(n);
            Print(matrix);
        }
    }

    private static int[,] Evaluate(int n)
    {
        int[,] matrix = new int[n, n];
        int[] position = { 0, -1 };
        int checkTurn = 0;
        int checker = 0;
        int value = 1;
        int length = n;


        for (int i = 0; i < (2 * n - 1); i++, checkTurn++, checker++)
        {
            if (checkTurn == 4)
            {
                checkTurn = 0;
            }
            else if (i > 0)
            {
                if (i == 1)
                {
                    checker = 0;
                    length--;
                }
                else if (checker == 2)
                {
                    checker = 0;
                    length--;
                }
            }

            for (int pos = 0; pos < length; pos++, value++)
            {
                switch (checkTurn)
                {
                    case 0: position[1]++; break;
                    case 1: position[0]++; break;
                    case 2: position[1]--; break;
                    case 3: position[0]--; break;
                }

                matrix[position[0], position[1]] = value;
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
                Console.Write("{0,2}", matrix[row, col]);

                if (col < matrix.GetLength(1) - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
