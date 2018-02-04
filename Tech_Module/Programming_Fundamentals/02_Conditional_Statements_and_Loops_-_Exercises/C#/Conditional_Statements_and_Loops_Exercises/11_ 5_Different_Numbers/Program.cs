using System;

namespace _11_5_Different_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            if (Math.Max(numberA, numberB) - Math.Min(numberA, numberB) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int n1 = numberA; n1 < numberB; n1++)
                {
                    for (int n2 = numberA; n2 < numberB; n2++)
                    {
                        for (int n3 = numberA; n3 < numberB; n3++)
                        {
                            for (int n4 = numberA; n4 < numberB; n4++)
                            {
                                for (int n5 = numberA; n5 <= numberB; n5++)
                                {
                                    if (numberA <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= numberB)
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}