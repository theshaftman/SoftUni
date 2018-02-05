using System;
using System.Linq;

namespace _03_Fold_and_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            // Fill second row array
            int[] secondRow = new int[array.Length / 2];
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = array[i + (array.Length / 4)];
            }

            // Fill first row array
            int[] firstRow = new int[array.Length / 2];
            int index = 0;
            for (int i = array.Length / 4 - 1; i >= 0; i--, index += 1)
            {
                firstRow[index] = array[i];
            }
            Array.Reverse(array);
            for (int i = 0; i < array.Length / 4; i++, index += 1)
            {
                firstRow[index] = array[i];
            }

            // Fill sum array
            int[] sumArray = new int[firstRow.Length];
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
