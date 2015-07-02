using System;

class MagicStrings
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 0 && n <= 100)
        {
            char[] str = new char[5];
            str[0] = 'k';
            str[1] = ' ';
            str[2] = 's';
            str[3] = 'n';
            str[4] = 'p';
            bool isThere = false;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    for (int k = 1; k <= 5; k++)
                    {
                        for (int l = 1; l <= 5; l++)
                        {
                            // half
                            for (int m = 1; m <= 5; m++)
                            {
                                for (int o = 1; o <= 5; o++)
                                {
                                    for (int p = 1; p <= 5; p++)
                                    {
                                        for (int r = 1; r <= 5; r++)
                                        {
                                            if (((i + j + k + l) - (m + o + p + r)) == n ||
                                                ((m + o + p + r) - (i + j + k + l)) == n)
                                            {
                                                if (i != 2 && j != 2 && k != 2 && l != 2 &&
                                                    m != 2 && o != 2 && p != 2 && r != 2)
                                                {
                                                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}",
                                                        str[i - 1], str[j - 1], str[k - 1], str[l - 1],
                                                        str[m - 1], str[o - 1], str[p - 1], str[r - 1]);

                                                    isThere = true;
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

            if (!isThere)
            {
                Console.WriteLine("No");
            }
        }
    }
}
