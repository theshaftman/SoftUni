using System;
using System.Text.RegularExpressions;

class ExtractURL
{
    static void Main()
    {
        //string str = "The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.";
        string str = Console.ReadLine();
        string[] result = str.Split(' ');
        string[] symbols = { ".", ",", "\"", "\'", "(", ")", 
                               "*", "&", "!", "?", "[", "]", ":", ";" };

        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 0; j < symbols.Length; j++)
            {
                if (result[i][result[i].Length - 1].ToString() == symbols[j])
                {
                    result[i] = result[i].Remove(result[i].Length - 1, 1);
                }
            }

            if (result[i].StartsWith("http://"))
            {
                Console.WriteLine(result[i]);
            }
            else if (result[i].StartsWith("www."))
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
