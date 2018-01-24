using System;

namespace _05_Word_in_Plural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.LastIndexOf("y") == word.Length - 1)
            {
                word = word.Substring(0, word.Length - 1) + "ies";
            }
            else if ((word.LastIndexOf("o") == word.Length - 1) ||
                  (word.LastIndexOf("s") == word.Length - 1) ||
                  (word.LastIndexOf("x") == word.Length - 1) ||
                  (word.LastIndexOf("z") == word.Length - 1) ||
                  (word.LastIndexOf("ch") == word.Length - 1 - 1) ||
                  (word.LastIndexOf("sh") == word.Length - 1 - 1))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
