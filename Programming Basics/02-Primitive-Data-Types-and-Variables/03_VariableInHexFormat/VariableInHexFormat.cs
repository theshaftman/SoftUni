using System;

class VariableInHexFormat
{
    static void Main()
    {
        int dec = 254;
        string hex = Convert.ToString(dec, 16).ToUpper();
        int hexToDec = Convert.ToInt32("0x" + hex, 16);

        Console.WriteLine("Hexadecimal: {0}", hex);
        Console.WriteLine("Decimal: {0}", hexToDec);
    }
}
