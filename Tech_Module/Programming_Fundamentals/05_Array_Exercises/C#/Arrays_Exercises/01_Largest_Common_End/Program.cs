using System;

namespace _01_Largest_Common_End
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstInputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondInputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int commonEnd = 0;
            int maxCommonEnd = 0;
            int minLength = Math.Min(firstInputArray.Length, secondInputArray.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstInputArray[i].Equals(secondInputArray[i]))
                {
                    commonEnd += 1;
                    continue;
                }
                break;
            }
            maxCommonEnd = commonEnd;
            commonEnd = 0;
            Array.Reverse(firstInputArray);
            Array.Reverse(secondInputArray);
            for (int i = 0; i < minLength; i++)
            {
                if (firstInputArray[i].Equals(secondInputArray[i]))
                {
                    commonEnd += 1;
                    continue;
                }
                break;
            }

            maxCommonEnd = Math.Max(maxCommonEnd, commonEnd);
            Console.WriteLine(maxCommonEnd);
        }
    }
}
