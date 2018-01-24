using System;

namespace _09_Count_the_Integers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line;
            int count = 0;
            while (true)
            {
                line = Console.ReadLine();
                try
                {
                    long number = long.Parse(line);
                    count += 1;
                }
                catch (Exception e)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
