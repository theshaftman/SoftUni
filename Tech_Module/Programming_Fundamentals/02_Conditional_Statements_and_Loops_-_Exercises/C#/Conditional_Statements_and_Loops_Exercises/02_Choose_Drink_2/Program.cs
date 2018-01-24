using System;

namespace _02_Choose_Drink_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            String drink;
            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }
            double totalPrice = 0.0;
            switch (drink)
            {
                case "Water":
                    totalPrice = (double)quantity * 0.7;
                    break;
                case "Coffee":
                    totalPrice = (double)quantity * 1.0;
                    break;
                case "Beer":
                    totalPrice = (double)quantity * 1.7;
                    break;
                case "Tea":
                    totalPrice = (double)quantity * 1.2;
                    break;
            }
            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
