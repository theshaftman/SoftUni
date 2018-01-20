using System;
using System.Numerics;

namespace _02_Add_Two_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BigInteger numberA = BigInteger.Parse(Console.ReadLine());
            BigInteger numberB = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = BigInteger.Add(numberA, numberB);
            Console.WriteLine("{0} + {1} = {2}", numberA, numberB, sum);
        }
    }
}
