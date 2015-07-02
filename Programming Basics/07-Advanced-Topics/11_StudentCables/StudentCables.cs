using System;

class StudentCables
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int[] cables = new int[n];

        for (int i = 0; i < cables.Length; i++)
        {
            int cable = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            if (cable >= 1 && cable <= 500)
            {
                if (str == "meters")
                {
                    cables[i] = cable * 100;
                }
                else if (str == "centimeters")
                {
                    cables[i] = cable;
                }
            }
        }

        if (n >= 1 && n <= 100)
        {
            ContinueSearch(cables);
        }
    }

    private static void ContinueSearch(int[] cables)
    {
        int[] usingCables = UsingCables(cables);
        int count = 0;

        foreach (var item in usingCables)
        {
            count += item;
        }

        count -= 2 * usingCables.Length;
        int add = usingCables.Length * 504;
        count -= add;
        int number = usingCables.Length;

        while (count <= 0)
        {
            count += 504;
            number--;
        }

        Console.WriteLine(number);
        Console.WriteLine(count);
    }

    private static int[] UsingCables(int[] cables)
    {
        int count = cables.Length;

        for (int i = 0; i < cables.Length; i++)
        {
            if (cables[i] < 20)
            {
                count--;
            }
        }

        int[] result = new int[count];
        int index = 0;

        for (int j = 0; j < cables.Length; j++)
        {
            if (cables[j] >= 20)
            {
                result[index] = cables[j];
                index++;
            }
        }

        return result;
    }
}
