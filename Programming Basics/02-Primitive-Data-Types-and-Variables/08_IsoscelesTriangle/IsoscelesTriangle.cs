using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        char str = '\u00A9';
        int rows = 4;

        for (int i = 0; i < 4; i++)
        {
            Console.Write(new string(' ', rows));

            if (i == 0)
            {
                Console.Write(str);
            }
            else if (i == 3)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(str + " ");
                }
            }
            else if (i % 2 != 0)
            {
                Console.Write(str);
                Console.Write(new string(' ', i));
                Console.Write(str);
            }
            else
            {
                Console.Write(str);
                Console.Write(new string(' ', i + 1));
                Console.Write(str);
            }

            Console.WriteLine();
            rows--;
        }
    }
}
