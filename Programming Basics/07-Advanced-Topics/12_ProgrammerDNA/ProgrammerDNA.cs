using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string start = Console.ReadLine();
        string[] chars = { "A", "B", "C", "D", "E", "F", "G" };

        if (n >= 7 && n <= 999)
        {
            int index = 0;
            int ind = char.Parse(start) - '0' + 48;

            for (int i = 0; i < n; i++, index++)
            {
                if (index == 7)
                {
                    index = 0;
                }

                Console.WriteLine(Check(ind, index));

                switch (index)
                {
                    case 0: ind++; break;
                    case 1: ind+=3; break;
                    case 2: ind+=5; break;
                    case 3: ind+=7; break;
                    case 4: ind+=5; break;
                    case 5: ind+=3; break;
                    case 6: ind++; break;
                }

                ind = CheckInt(ind);
            }
        }
    }

    private static string Check(int ind, int index)
    {
        string result = string.Empty;

        for (int i = index; i < index + 1; i++)
        {
            if (i == 0 || i == 6)
            {
                result = new string('.', 3) + (char)(CheckInt(ind)) + new string('.', 3);
            }
            else if (i == 1 || i == 5)
            {
                string add = string.Empty;

                for (int j = 0; j < 3; j++, ind++)
                {
                    add += (char)CheckInt(ind);
                }

                result = new string('.', 2) + add + new string('.', 2);
            }
            else if (i == 2 || i == 4)
            {
                string add = string.Empty;

                for (int j = 0; j < 5; j++, ind++)
                {
                    add += (char)CheckInt(ind);
                }

                result = new string('.', 1) + add + new string('.', 1);
            }
            else
            {
                for (int j = 0; j < 7; j++, ind++)
                {
                    result += (char)(CheckInt(ind));
                }
            }
        }

        return result;
    }

    private static int CheckInt(int n)
    {
        if (n == 72)
        {
            return 65;
        }
        if (n > 72)
        {
            return 65 + (n - 72);
        }

        return n;
    }
}
