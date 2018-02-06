using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Search_for_a_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<long> list = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            string[] parameters = Console.ReadLine()
                .Split(' ');
            List<long> filteredList = list
                .GetRange(0, int.Parse(parameters[0]))
                .Skip(int.Parse(parameters[1]))
                .Where(m => m.Equals(long.Parse(parameters[2])))
                .ToList();
            string result = filteredList.Count > 0 ? "YES!" : "NO!";
            Console.WriteLine(result);
        }
    }
}
