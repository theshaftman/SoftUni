﻿using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        int change = 5;
        a = b;
        b = change;

        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}
