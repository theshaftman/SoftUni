using System;
using System.Linq;

namespace _05_Compare_Char_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] arrayA = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] arrayB = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            int equallityIndex = ArraysEqualIndex(arrayA, arrayB);

            if (!equallityIndex.Equals(-1))
            {
                Console.WriteLine(string.Join("", arrayA));
                Console.WriteLine(string.Join("", arrayB));
            }
            else
            {
                Console.WriteLine(string.Join("", arrayB));
                Console.WriteLine(string.Join("", arrayA));
            }
        }

        private static int ArraysEqualIndex(char[] arrayA, char[] arrayB)
        {
            int minLength = Math.Min(arrayA.Length, arrayB.Length);
            for (int i = 0; i < minLength; i++)
            {
                if ((int)arrayA[i] > (int)arrayB[i])
                {
                    return -1;
                }
                else if ((int)arrayA[i] < (int)arrayB[i])
                {
                    return 1;
                }
            }
            if (arrayA.Length > arrayB.Length)
            {
                return -1;
            }
            else if (arrayB.Length > arrayA.Length)
            {
                return 1;
            }
            return 0;
        }
    }
}
