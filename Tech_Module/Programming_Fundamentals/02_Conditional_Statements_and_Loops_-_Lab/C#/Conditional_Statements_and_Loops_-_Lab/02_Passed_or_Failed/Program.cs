using System;

namespace _02_Passed_or_Failed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());
            string markString = string.Empty;
            if (mark >= 3.0)
            {
                markString = "Passed!";
            }
            else
            {
                markString = "Failed!";
            }
            Console.WriteLine(markString);
        }
    }
}
