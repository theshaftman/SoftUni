using System;
using System.Linq;
using System.Collections.Generic;

class FiveSpecialLetters
{
    static void Main()
    {
        SpecialLetters();
    }

    private static void SpecialLetters()
    {
        int start = CheckInt();
        int end = CheckInt();

        string[] letters = { "a", "b", "c", "d", "e" };
        List<string> result = new List<string>();
        string word = string.Empty;

        for (int i = end; i >= start; i--)
		{
            for (int a = 0; a < letters.Length; a++)
            {
                string first = letters[a];

                for (int b = 0; b < letters.Length; b++)
                {
                    string second = letters[b];

                    for (int c = 0; c < letters.Length; c++)
                    {
                        string third = letters[c];

                        for (int d = 0; d < letters.Length; d++)
                        {
                            string fourth = letters[d];

                            for (int e = 0; e < letters.Length; e++)
                            {
                                string fifth = letters[e];

                                word = first + second + third + fourth + fifth;
                                int wordWeight = Weight(word);

                                if (wordWeight == i)
                                {
                                    result.Add(word);
                                }
                            }
                        }
                    }
                }
            }
		}

        Print(result);
    }

    private static int CheckInt()
    {
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers))
        {
            return int.Parse(str);
        }

        return 0;
    }

    private static int Weight(string word)
    {
        string result = new string(word.ToCharArray().Distinct().ToArray());
        int weight = 0;

        for (int i = 0; i < result.Length; i++)
        {
            weight += (i + 1) * CharWeight(result[i]);
        }

        return weight;
    }

    private static int CharWeight(char ch)
    {
        int weight = 0;

        switch (ch)
        {
            case 'a': weight = 5; break;
            case 'b': weight = -12; break;
            case 'c': weight = 47; break;
            case 'd': weight = 7; break;
            case 'e': weight = -32; break;
        }

        return weight;
    }

    private static void Print(List<string> result)
    {
        if (result.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            result.Sort();

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);

                if (i < result.Count - 1)
                {
                    Console.Write(" ");
                }
                else if (i == result.Count - 1)
                {
                    Console.WriteLine();
                }
            }
        }        
    }
}
