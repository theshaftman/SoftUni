using System;
using System.Linq;

namespace _02_Rotate_and_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int turns = int.Parse(Console.ReadLine());

            int[] transformedArray = new int[array.Length];
            int[] sumArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int sum = array[i];
                for (int j = 1; j < turns; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        transformedArray[(k + j) % array.Length] = array[k];
                    }
                    sum += transformedArray[i];
                }
                sumArray[(i + 1) % array.Length] = sum;
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
