using System;

namespace _06_Theatre_Promotion
{
    public class Program
    {
        private static string weekDay;
        private static int age;
        private static string errorView = "Error!";

        public static void Main(string[] args)
        {
            weekDay = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            string price;
            switch (weekDay)
            {
                case "Weekday":
                    price = PriceSelection(new int[] {12, 18, 12});
                    break;
                case "Weekend":
                    price = PriceSelection(new int[] {15, 20, 15});
                    break;
                case "Holiday":
                    price = PriceSelection(new int[] {5, 12, 10});
                    break;
                default:
                    price = errorView;
                    break;
            }
            Console.WriteLine("{0}", price);
        }

        private static string PriceSelection(int[] values)
        {
            if (0 <= age && age <= 18)
            {
                return values[0].ToString() + "$";
            }
            else if (18 < age && age <= 64)
            {
                return values[1].ToString() + "$";
            }
            else if (64 < age && age <= 122)
            {
                return values[2].ToString() + "$";
            }
            else
            {
                return errorView;
            }
        }
    }
}
