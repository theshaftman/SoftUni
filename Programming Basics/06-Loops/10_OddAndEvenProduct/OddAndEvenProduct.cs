using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine(Product());
    }

    private static string Product()
    {
        string str = Console.ReadLine();
        string[] arr = str.Split(' ');
        int prodOdd = 1;
        int prodEven = 1;
        string result = string.Empty;

        try
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    prodOdd *= int.Parse(arr[i]);
                }
                else
                {
                    prodEven *= int.Parse(arr[i]);
                }
            }
        }
        catch (Exception)
        {
            prodOdd = -1;
            prodEven = -1;
        }
        

        if (prodEven == prodOdd)
        {
            result = "yes" + Environment.NewLine + 
                "product = " + prodEven;
        }
        else
        {
            result = "no" + Environment.NewLine +
                "odd_product = " + prodOdd + Environment.NewLine +
                "even_product = " + prodEven;
        }

        return result;
    }
}
