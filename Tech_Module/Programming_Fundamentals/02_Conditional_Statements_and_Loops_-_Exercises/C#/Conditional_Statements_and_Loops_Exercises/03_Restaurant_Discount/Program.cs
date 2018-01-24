using System;

namespace _03_Restaurant_Discount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string groupPackage = Console.ReadLine();
            string hall;
            double allPrice;

            if (groupSize > 0 && groupSize <= 50)
            {
                hall = "Small Hall";
                allPrice = 2500.0;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                allPrice = 5000.0;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                allPrice = 7500.0;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (groupPackage)
            {
                case "Normal":
                    allPrice = ((allPrice + 500.0) - ((allPrice + 500.0) * 0.05)) / (double)groupSize;
                    break;
                case "Gold":
                    allPrice = ((allPrice + 750.0) - ((allPrice + 750.0) * 0.1)) / (double)groupSize;
                    break;
                case "Platinum":
                    allPrice = ((allPrice + 1000.0) - ((allPrice + 1000.0) * 0.15)) / (double)groupSize;
                    break;
            }

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {allPrice:F2}$");
        }
    }
}
