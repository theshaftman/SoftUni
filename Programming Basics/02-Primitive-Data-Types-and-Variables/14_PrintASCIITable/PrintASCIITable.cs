using System;

class PrintASCIITable
{
    static void Main()
    {
        Console.WriteLine("ASCII Table:");

        for (byte i = 0; i < byte.MaxValue; i++)
        {
            Console.WriteLine("[{0}] -> {1}", i, (char)i);
        }
    }
}
