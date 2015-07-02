using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string varA = Console.ReadLine();
        string varB = Console.ReadLine();

        string[] arr = varA.Split(' ');
        string[] add = varB.Split(' ');
        IEnumerable<int> result = Value(arr, add).Distinct();
        var endResult = from element in result
                        orderby element
                        select element;

        foreach (var item in endResult)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }

    private static List<int> Value(string[] arr, string[] add)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            result.Add(int.Parse(arr[i]));
        }

        for (int j = 0; j < add.Length; j++)
        {
            result.Add(int.Parse(add[j]));
        }

        return result;
    }
}
