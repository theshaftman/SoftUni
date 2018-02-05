using System;

namespace _09_Index_of_Letters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} -> {array[i] - 97}");
            }   
        }
    }
}
