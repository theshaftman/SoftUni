using System;

namespace _08_Sum_of_Odd_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0l;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0 && n > 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                    n -= 1;
                }
                if (n == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
