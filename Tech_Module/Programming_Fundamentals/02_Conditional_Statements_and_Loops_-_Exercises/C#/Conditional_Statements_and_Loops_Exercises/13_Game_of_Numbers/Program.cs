using System;

namespace TestProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int combinations = 0;

            for (int i = numA; i <= numB; i++)
            {
                for (int j = numA; j <= numB; j++)
                {
                    currentSum = i + j;
                    combinations += 1;
                    if (currentSum.Equals(sum))
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {currentSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {sum}");
        }
    }
}