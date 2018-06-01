using System;

namespace _06_Car_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int p1 = start; p1 <= end; p1++)
            {
                for (int p2 = start; p2 <= end; p2++)
                {
                    for (int p3 = start; p3 <= end; p3++)
                    {
                        for (int p4 = start; p4 <= end; p4++)
                        {
                            if ((p1 % 2 == 0 && p4 % 2 != 0) || (p1 % 2 != 0 && p4 % 2 == 0))
                            {
                                if (p1 > p4)
                                {
                                    if ((p2 + p3) % 2 == 0)
                                    {
                                        Console.Write($"{p1}{p2}{p3}{p4} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
