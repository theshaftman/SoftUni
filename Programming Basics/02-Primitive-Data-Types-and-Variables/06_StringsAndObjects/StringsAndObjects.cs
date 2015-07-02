using System;

class StringsAndObjects
{
    static void Main()
    {
        string strA = "Hello";
        string strB = "World";
        object obj = strA + " " + strB;

        string strC = Convert.ToString(obj);

        Console.WriteLine(obj.GetType());
        Console.WriteLine(strC);
    }
}
