using System;
using System.Linq;

namespace _07_Max_Sequence_of_Increasing_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int bestLength = -1;
            int bestIndex = -1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int checkedIndex = i;
                int checkedNextIndex = i + 1;
                int currentLength = 1;
                while (array[checkedNextIndex] > array[checkedIndex])
                {
                    checkedIndex += 1;
                    checkedNextIndex += 1;
                    currentLength += 1;
                    if (checkedIndex >= array.Length || checkedNextIndex >= array.Length)
                    {
                        break;
                    }
                }
                if (currentLength > 1 && currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestIndex = i;
                }
            }

            for (int i = bestIndex; i < bestIndex + bestLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
