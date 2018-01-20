using System;

namespace _05_Character_Stats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {1}{0}Health: |{2}|{0}Energy: |{3}|",
                Environment.NewLine,
                name,
                new string('|', currentHealth) + new string('.', maximumHealth - currentHealth),
                new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy));
        }
    }
}
