using System;

namespace _10_Multiplication_Table_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            short startIndex = short.Parse(Console.ReadLine());
            if (startIndex >= 0 && startIndex <= 10)
            {
                for (short i = startIndex; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}",
                            n,
                            i,
                            (n * i));
                }
            }
            else
            {
                Console.WriteLine("{0} X {1} = {2}",
                    n,
                    startIndex,
                    (n * startIndex));
            }
        }
    }
}
