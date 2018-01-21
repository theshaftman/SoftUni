using System;

namespace _05_Foreign_Languages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string result = string.Empty;
            switch (country)
            {
                case "England":
                case "USA":
                    result = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    result = "Spanish";
                    break;
                default:
                    result = "unknown";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
