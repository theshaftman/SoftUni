using System;

namespace _09_Multiplication_Table
{
    public class Program
    {
        public static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            for (short i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}",
                        n,
                        i,
                        (n * i));
            }
        }
    }
}
