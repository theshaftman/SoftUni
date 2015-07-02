using System;
using System.Threading;

class FallingRocks
{
    private static int height = 15;
    private static int width = 20;
    private static string[,] matrix = new string[height, width];
    private static int playerPosition = width / 2;
    private static Random randomGenerator = new Random();
    private static string[] problemView = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
    private static string[] rowMinus = new string[matrix.GetLength(1)];

    static void Main()
    { 
        //PlayerMove();
        Begin();
        int num = 0;

        while (true)
        {
            Console.Clear();
            Move();
            Print();
            //PlayerMove();

            Thread.Sleep(150);
            num++;
        }
    }

    private static void PlayerMove()
    {
        string key = Console.ReadKey().Key.ToString();

        if (key == "LeftArrow")
        {
            if (playerPosition > 0)
            {
                playerPosition--;
            }
        }
        else if (key == "RightArrow")
        {
            if (playerPosition < width - 1)
            {
                playerPosition++;
            }
        }
    }

    private static void Move()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (row == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[0, col] = " ";
                }

                int numberOfProblems = randomGenerator.Next(5);

                for (int j = 0; j < numberOfProblems; j++)
                {
                    int probl = randomGenerator.Next(matrix.GetLength(1));
                    matrix[0, probl] = problemView[randomGenerator.Next(problemView.Length)];
                }
            }
            else if (row == 1)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[2, col] = matrix[1, col];
                    matrix[1, col] = rowMinus[col];
                }
            }
            else if (row > 1 && row < matrix.GetLength(0) - 1)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row + 1, col] = matrix[row, col];
                }
            }
            else if (row == matrix.GetLength(0) - 1)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == matrix.GetLength(0) - 1 && col == playerPosition)
                    {
                        matrix[row, col] = "0";
                    }
                    else if (row == matrix.GetLength(0) - 1 && col == playerPosition - 1)
                    {
                        matrix[row, col] = "(";
                    }
                    else if (row == matrix.GetLength(0) - 1 && col == playerPosition + 1)
                    {
                        matrix[row, col] = ")";
                    }
                    else
                    {
                        matrix[row, col] = matrix[row - 1, col];
                    }
                }
            }
        }

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            rowMinus[i] = matrix[0, i];
        }
    }

    private static void Begin()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = " ";
            }
        }

        for (int i = 0; i < rowMinus.Length; i++)
        {
            rowMinus[i] = " ";
        }
    }

    private static void Print()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}
