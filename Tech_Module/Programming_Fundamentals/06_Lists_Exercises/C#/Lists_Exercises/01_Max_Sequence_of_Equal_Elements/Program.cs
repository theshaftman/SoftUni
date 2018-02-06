using System;
using System.Linq;

namespace _01_Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal[] array = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToArray();

            int maxCounter = 0;
            int maxIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int counter = 1;
                int index = i;
                int upperIndex = i + 1;
                while (array[upperIndex].Equals(array[index]))
                {
                    upperIndex += 1;
                    index += 1;
                    counter += 1;
                    if (upperIndex > array.Length - 1)
                    {
                        break;
                    }
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxIndex = i;
                }
            }
            for (int i = maxIndex; i < maxIndex + maxCounter; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
