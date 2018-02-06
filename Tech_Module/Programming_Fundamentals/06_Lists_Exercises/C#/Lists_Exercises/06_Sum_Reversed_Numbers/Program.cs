using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Sum_Reversed_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(' ')
                .ToList();
            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += long.Parse(string.Join("", list[i].Reverse()));
            }
            Console.WriteLine(sum);
        }
    }
}
