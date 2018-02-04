using System;

namespace TestProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double peshoDamage = double.Parse(Console.ReadLine());
            double goshoDamage = double.Parse(Console.ReadLine());

            double peshoLife = 100.0;
            double goshoLife = 100.0;
            int move = 0;

            while (peshoLife > 0.0 || goshoLife > 0.0)
            {
                move += 1;
                if (move % 2 != 0)
                {
                    goshoLife -= peshoDamage;
                    if (goshoLife <= 0.0)
                    {
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoLife);
                }
                else
                {
                    peshoLife -= goshoDamage;
                    if (peshoLife <= 0.0)
                    {
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoLife);
                }
                if (move > 0 && move % 3 == 0)
                {
                    peshoLife += 10.0;
                    goshoLife += 10.0;
                }
            }
            string winner = peshoLife > 0.0 ? "Pesho" : "Gosho";
            Console.WriteLine("{0} won in {1}th round.", winner, move);
        }
    }
}
