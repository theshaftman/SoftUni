using System;
using System.Linq;

namespace _06_Max_Sequence_of_Equal_Elements
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
            for (int i = 0; i < array.Length; i++)
            {
                int checkedIndex = i;
                int currentLength = 0;
                while (array[checkedIndex].Equals(array[i]))
                {
                    checkedIndex += 1;
                    currentLength += 1;
                    if (checkedIndex >= array.Length)
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

            if (!bestIndex.Equals(-1))
            {
                for (int i = bestIndex; i < bestIndex + bestLength; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(array[0]);
            }
        }
    }
}
