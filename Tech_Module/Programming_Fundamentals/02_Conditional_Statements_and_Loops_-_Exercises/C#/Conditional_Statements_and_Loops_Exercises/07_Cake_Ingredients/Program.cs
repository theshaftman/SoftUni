using System;

namespace _07_Cake_Ingredients
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line;
            int count = 0;
            while (!(line = Console.ReadLine()).Equals("Bake!"))
            {
                Console.WriteLine($"Adding ingredient {line}.");
                count += 1;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
