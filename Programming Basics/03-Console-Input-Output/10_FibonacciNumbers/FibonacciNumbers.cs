using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int fibonacciA = 0;
        int fibonacciB = 1;
        string result = "0";

        if (n > 0)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int sum = fibonacciA + fibonacciB;

                fibonacciA = fibonacciB;
                fibonacciB = sum;
                result += " " + fibonacciA.ToString();
            }
        }
        
        Console.WriteLine(result);
    }
}
