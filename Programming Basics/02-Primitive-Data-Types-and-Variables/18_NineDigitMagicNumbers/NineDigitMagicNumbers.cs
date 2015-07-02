using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        if (sum >= 0 && sum <= 100)
        {
            if (diff >= 0 && diff <= 1000)
            {
                int digSum = 0;
                int abc = 0;
                int def = 0;
                int ghi = 0;
                bool noResult = true;

                for (int a = 1; a <= 7; a++)
                {
                    for (int b = 1; b <= 7; b++)
                    {
                        for (int c = 1; c <= 7; c++)
                        {
                            for (int d = 1; d <= 7; d++)
                            {
                                for (int e = 1; e <= 7; e++)
                                {
                                    for (int f = 1; f <= 7; f++)
                                    {
                                        for (int g = 1; g <= 7; g++)
                                        {
                                            for (int h = 1; h <= 7; h++)
                                            {
                                                for (int i = 1; i <= 7; i++)
                                                {
                                                    digSum = a + b + c + d + e + f + g + h + i;

                                                    if (digSum == sum)
                                                    {
                                                        abc = a * 100 + b * 10 + c;
                                                        def = d * 100 + e * 10 + f;
                                                        ghi = g * 100 + h * 10 + i;

                                                        if ((abc <= def) && (def - abc == ghi - def) && (def - abc == diff))
                                                        {
                                                            Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                                                            noResult = false;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (noResult)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
