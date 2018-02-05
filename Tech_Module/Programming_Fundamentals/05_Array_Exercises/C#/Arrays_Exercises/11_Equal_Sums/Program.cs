using System;
using System.Linq;

namespace _11_Equal_Sums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int equalIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum.Equals(rightSum))
                {
                    equalIndex = i;
                    break;
                }
            }

            if (!equalIndex.Equals(-1))
            {
                Console.WriteLine(equalIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
