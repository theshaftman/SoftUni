using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // number of numbers

        if (n >= 0 && n <= 500)
        {
            int sumA = 0;
            int sumB = 0;

            for (int i = 0; i < n; i++)
            {
                int checkA = int.Parse(Console.ReadLine());

                if (checkA >= -500000 && checkA <= 500000)
                {
                    sumA += checkA;
                }
            }
            
            for (int j = 0; j < n; j++)
            {
                int checkB = int.Parse(Console.ReadLine());

                if (checkB >= -500000 && checkB <= 500000)
                {
                    sumB += checkB;
                }
            }

            if (sumA == sumB)
            {
                Console.WriteLine("Yes, sum={0}", sumA);
            }
            else
            {
                string difference = (sumA - sumB).ToString();

                if (difference[0] == '-')
                {
                    difference = difference.Remove(0, 1);
                }

                Console.WriteLine("No, diff={0}", difference);
            }
        }
    }
}
