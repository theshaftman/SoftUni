using System;
using System.Text;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 100)
        {
            if (step >= 1 && step <= 20)
            {
                int[] numbers = new int[n];

                for (int i = 0; i < numbers.Length; i++)
                {
                    int check = int.Parse(Console.ReadLine());

                    if (check >= 0 && check <= 255)
                    {
                        numbers[i] = check;
                    }
                }

                string[] binNumbers = new string[n];

                for (int j = 0; j < binNumbers.Length; j++)
                {
                    string bin = Convert.ToString(numbers[j], 2);
                    string addZeroes = string.Empty;

                    if (bin.Length < 8)
                    {
                        addZeroes = new string('0', (8 - bin.Length));
                    }

                    binNumbers[j] = addZeroes + bin;
                }

                string result = string.Empty;

                for (int k = 0; k < binNumbers.Length; k++)
                {
                    result += binNumbers[k];
                }
                
                string change = Change(result, step);

                //////////////////////////
                //Console.WriteLine(result);
                //Console.WriteLine(change);

                for (int l = 0; l < binNumbers.Length; l++)
                {
                    binNumbers[l] = "";

                    for (int m = 0; m < 8; m++)
                    {
                        binNumbers[l] += change[m + (l * 8)];
                    }
                }

                for (int o = 0; o < binNumbers.Length; o++)
                {
                    int dec = Convert.ToInt32(binNumbers[o], 2);

                    Console.WriteLine(dec);
                }
            }
        }
    }

    private static int position = 0;

    private static string Change(string str, int step)
    {
        if (position <= str.Length)
        {
            try
            {
                StringBuilder strBuilder = new StringBuilder(str);
                char ch = strBuilder[position];

                if (ch == '0')
                {
                    strBuilder[position] = '1';
                }
                else
                {
                    strBuilder[position] = '0';
                }

                str = strBuilder.ToString();
                position += step;

                return Change(str, step);
            }
            catch (Exception) { }
        }

        return str;
    }
}
