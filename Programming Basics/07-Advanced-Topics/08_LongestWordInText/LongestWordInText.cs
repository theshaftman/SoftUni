using System;
using System.Text.RegularExpressions;

class LongestWordInText
{
    static void Main()
    {
        string str = Console.ReadLine();
        Regex regex = new Regex("[^a-zA-Z0-9 -]");
        str = regex.Replace(str, String.Empty);

        string[] words = str.Split(' ');
        string longest = FindLongest(words);

        Console.WriteLine(longest);
    }

    private static string FindLongest(string[] arr)
    {
        int max = 0;
        string result = string.Empty;

        for (int i = 0; i < arr.Length; i++)
        {
            int length = arr[i].Length;

            if (length > max)
            {
                max = length;
                result = arr[i];
            }
        }

        return result;
    }
}
