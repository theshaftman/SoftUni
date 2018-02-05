using System;
using System.Linq;

namespace _08_Most_Frequent_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ushort[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(ushort.Parse)
                .ToArray();

            int bestLength = -1;
            int bestIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                int currentLength = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i].Equals(array[j]))
                    {
                        currentLength += 1;
                    }
                }

                if (currentLength > 1 && currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestIndex = i;
                }
            }

            if (bestIndex > -1)
            {
                Console.WriteLine(array[bestIndex]);
            }
            else
            {
                Console.WriteLine(array[0]);
            }
        }
    }
}
