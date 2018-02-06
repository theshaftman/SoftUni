using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Bomb_Numbers
{
    public class Program
    {
        private static int[] parameters;
        private static List<int> indexes;

        public static void Main(string[] args)
        {
            List<long> list = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            parameters = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            List<int> indexes = new List<int>();

            while (!list.IndexOf(parameters[0]).Equals(-1))
            {
                UpdateList(ref list);
            }
            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }

        private static void UpdateList(ref List<long> list)
        {
            indexes = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(parameters[0]))
                {
                    for (int j = i; j <= i + parameters[1]; j++)
                    {
                        if (j >= list.Count)
                        {
                            break;
                        }
                        if (indexes.IndexOf(j).Equals(-1))
                        {
                            indexes.Add(j);
                        }
                    }
                    for (int j = i - 1; j >= i - parameters[1]; j--)
                    {
                        if (j < 0)
                        {
                            break;
                        }
                        indexes.Add(j);
                    }

                    indexes = indexes
                        .OrderBy(m => m)
                        .ToList();
                    for (int j = indexes.Count - 1; j >= 0; j--)
                    {
                        list.RemoveAt(indexes[j]);
                    }
                    return;
                }
            }
        }
    }
}
