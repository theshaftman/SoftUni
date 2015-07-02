using System;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 100)
        {
            if (step >= 1 && step <= 20)
            {
                string[] bin = new string[n];

                for (int i = 0; i < bin.Length; i++)
                {
                    //Get the n numbers
                    int m = int.Parse(Console.ReadLine());

                    if (m >= 0 && m <= 255)
                    {
                        string str = Convert.ToString(m, 2);
                        string result = string.Empty;

                        //Check length after converting to binary
                        if (str.Length < 8)
                        {
                            result = new string('0', 8 - str.Length);
                        }

                        result += str;
                        bin[i] = result;
                    }
                }

                //Create the full number
                string result1 = string.Empty;

                for (int j = 0; j < bin.Length; j++)
                {
                    result1 += bin[j];
                }

                //Get the numbers at the positions
                int position = 1;
                string result2 = string.Empty;

                while (position <= result1.Length)
                {
                    result2 += result1[position].ToString();
                    position += step;
                }

                //Check the number of output numbers
                double numbers = result2.Length / 8.0;
                string strNumbers = numbers.ToString();
                string count = string.Empty;
                string diff = "0";

                //Get the number before the '.'
                for (int k = 0; k < strNumbers.Length; k++)
                {
                    if (strNumbers[k] == '.')
                    {
                        try
                        {
                            diff = strNumbers[k + 1].ToString();
                        }
                        catch (Exception) { }
                        break;
                    }

                    count += strNumbers[k];
                }

                int countInt = Convert.ToInt32(count);
                int diffInt = Convert.ToInt32(diff);

                //If diff > 0 => the number of output numbers rises by one
                if (diffInt > 0)
                {
                    countInt++;
                }

                //Divide the created value by 8 and add it in 'resultBin' array
                string[] resultBin = new string[countInt];

                for (int m = 0; m < resultBin.Length; m++)
                {
                    string tryIt = string.Empty;

                    for (int y = 0; y < 8; y++)
                    {
                        try
                        {
                            tryIt += result2[y + (m * 8)].ToString();
                        }
                        catch (Exception) { }
                    }

                    resultBin[m] = tryIt;
                }

                //Output the bin numbers in decimal format
                for (int z = 0; z < resultBin.Length; z++)
                {
                    if (resultBin[z].Length < 8)
                    {
                        resultBin[z] += new string('0', 8 - resultBin[z].Length);
                    }

                    Console.WriteLine(Convert.ToInt32(resultBin[z], 2));
                }
            }
        }
    }
}
