using System;

namespace _01_Debit_Card_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arrayStr = new string[4];
            for (int i = 0; i < arrayStr.Length; i++)
            {
                arrayStr[i] = string.Format("{0:D4}", long.Parse(Console.ReadLine()));
            }
            Console.WriteLine(string.Join(" ", arrayStr));
        }
    }
}
