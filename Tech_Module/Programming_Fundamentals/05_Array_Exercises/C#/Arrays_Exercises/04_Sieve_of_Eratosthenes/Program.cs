using System;

namespace _04_Sieve_of_Eratosthenes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] array = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                array[i] = true;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i])
                {
                    for (int p = 2; (p * i) <= n; p++)
                    {
                        array[p * i] = false;
                    }
                }
            }
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
