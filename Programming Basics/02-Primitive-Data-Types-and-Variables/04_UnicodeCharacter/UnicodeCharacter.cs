using System;

class UnicodeCharacter
{
    static void Main()
    {
        int dec = 42;
        string hex = Convert.ToString(dec, 16).ToUpper();
        string charStr = "'\\u00" + hex + "'";
        char ch = '\u002A';

        Console.WriteLine("Char: {0}", charStr);
        Console.WriteLine(ch);
    }
}
