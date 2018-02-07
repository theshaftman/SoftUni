using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Array_Manipulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string line = string.Empty;
            while (!(line = Console.ReadLine()).Equals("print"))
            {
                string[] lineArray = line.Split(' ');
                if (lineArray[0].Equals("add"))
                {
                    list.Insert(int.Parse(lineArray[1]), int.Parse(lineArray[2]));
                }
                else if (lineArray[0].Equals("addMany"))
                {
                    var collection = lineArray
                        .Skip(2)
                        .Select(int.Parse)
                        .ToList();
                    list.InsertRange(int.Parse(lineArray[1]), collection);
                }
                else if (lineArray[0].Equals("contains"))
                {
                    Console.WriteLine(list.IndexOf(int.Parse(lineArray[1])));
                }
                else if (lineArray[0].Equals("remove"))
                {
                    list.RemoveAt(int.Parse(lineArray[1]));
                }
                else if (lineArray[0].Equals("shift"))
                {
                    var rotated = new List<int>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        rotated.Add(list[(i + int.Parse(lineArray[1])) % list.Count]);
                    }
                    list.Clear();
                    list.AddRange(rotated);
                }
                else if (lineArray[0].Equals("sumPairs"))
                {
                    var sumList = new List<int>();
                    for (int i = 0; i < list.Count - 1; i += 2)
                    {
                        sumList.Add(list[i] + list[i + 1]);
                    }
                    if (list.Count % 2 != 0)
                    {
                        sumList.Add(list[list.Count - 1]);
                    }
                    list.Clear();
                    list.AddRange(sumList);
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}
