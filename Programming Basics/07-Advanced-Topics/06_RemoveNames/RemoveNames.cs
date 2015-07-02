using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string rowInput = Console.ReadLine();
        string rowRemove = Console.ReadLine();

        List<string> result = new List<string>(rowInput.Split(' '));
        string[] remove = rowRemove.Split(' ');

        for (int i = 0; i < remove.Length; i++)
        {
            result = Remove(remove[i], result);
        }

        foreach (var item in result)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }

    private static List<string> Remove(string item, List<string> result)
    {
        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] == item)
            {
                result.Remove(result[i]);
                i--;
            }
        }

        return result;
    }
}
