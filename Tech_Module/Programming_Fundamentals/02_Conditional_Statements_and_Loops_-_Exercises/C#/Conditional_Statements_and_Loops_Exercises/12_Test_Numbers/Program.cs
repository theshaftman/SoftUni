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
            int countCombinations = 0;
            int currentSum = 0;

            for (int i = numA; i > 0; i--)
            {
                for (int j = 1; j <= numB; j++)
                {
                    if (currentSum >= sum)
                    {
                        break;
                    }
                    countCombinations += 1;
                    currentSum += (3 * (i * j));
                }
            }
            string resultSum = currentSum >= sum ? (currentSum + " >= " + sum) : currentSum.ToString();

            Console.WriteLine("{0} combinations", countCombinations);
            Console.WriteLine("Sum: {0}", resultSum);
        }
    }
}