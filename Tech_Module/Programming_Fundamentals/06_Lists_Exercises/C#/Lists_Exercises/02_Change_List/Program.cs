using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<long> list = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            string line = Console.ReadLine();
            while (!line.Equals("Odd") && !line.Equals("Even"))
            {
                string[] lineElements = line.Split(' ');
                if (lineElements[0].Equals("Insert"))
                {
                    list.Insert(int.Parse(lineElements[2]), long.Parse(lineElements[1]));
                }
                else if (lineElements[0].Equals("Delete"))
                {
                    list.RemoveAll(m => m.Equals(long.Parse(lineElements[1])));
                }
                line = Console.ReadLine();
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (line.Equals("Odd") && list[i] % 2 != 0)
                {
                    Console.Write($"{list[i]} ");
                }
                else if (line.Equals("Even") && list[i] % 2 == 0)
                {
                    Console.Write($"{list[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
