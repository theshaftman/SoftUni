using System;

namespace _12_Number_checker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();
            try
            {
                double number = double.Parse(line);
                Console.WriteLine("It is a number.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
