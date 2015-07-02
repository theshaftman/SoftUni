using System;

class PrintLongSequence
{
    static void Main()
    {
        string result = string.Empty;
        int i = 0;

        while (i < 1000)
        {
            if (i != 0)
            {
                result += ",";
            }
            if (i % 2 != 0)
            {
                result += "-";
            }

            result += (i + 2);

            i++;
        }

        Console.WriteLine(result);
    }
}
