using System;

namespace _08_Calories_Counter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                if (line.ToLower().Equals("Cheese".ToLower()))
                {
                    calories += 500;
                }
                else if (line.ToLower().Equals("Tomato sauce".ToLower()))
                {
                    calories += 150;
                }
                else if (line.ToLower().Equals("Salami".ToLower()))
                {
                    calories += 600;
                }
                else if (line.ToLower().Equals("Pepper".ToLower()))
                {
                    calories += 50;
                }
            }
            Console.WriteLine("Total calories: " + calories);
        }
    }
}
