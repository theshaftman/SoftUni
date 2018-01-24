using System;

namespace _10_Triangle_of_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{i + 1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
