﻿using System;

namespace TestProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine();
            string result = string.Empty;

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        result = string.Format($"{i}{j}{k}");
                        if (!result.Contains(skip))
                        {
                            Console.Write(result + " ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}