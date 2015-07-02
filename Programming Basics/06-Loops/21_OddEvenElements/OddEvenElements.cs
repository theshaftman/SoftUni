using System;

class OddEvenElements
{
    static void Main()
    {
        Elements();
    }

    private static void Elements()
    {
        string str = Console.ReadLine();
        string[] arrStr = str.Split(' ');

        double[] arr = ArrValues(arrStr);
        double[] oddValues = FindValues(arr, true);
        double[] evenValues = FindValues(arr, false);
        string oddSum = string.Empty;
        string evenSum = string.Empty;

        if (oddValues.Length == 0)
        {
            oddSum = "No";
        }
        if (oddValues.Length > 0)
        {
            oddSum = FindSum(arr, true).ToString();
        }
        if (evenValues.Length == 0)
        {
            evenSum = "No";
        }
        if (evenValues.Length > 0)
        {
            evenSum = FindSum(arr, false).ToString();
        }
            
        Console.WriteLine("OddSum=" + oddSum + ", OddMin=" + FindMin(oddValues) +
            ", OddMax=" + FindMax(oddValues) + ", EvenSum=" + evenSum + 
            ", EvenMin=" + FindMin(evenValues) + ", EvenMax=" + FindMax(evenValues));
    }

    private static double[] ArrValues(string[] arrStr)
    {
        double[] arr = new double[arrStr.Length];
        double numbers;

        for (int i = 0; i < arrStr.Length; i++)
        {
            if (double.TryParse(arrStr[i], out numbers))
            {
                arr[i] = double.Parse(arrStr[i]);
            }
            else
            {
                return new double[] { -1 };
            }
        }

        return arr;
    }

    private static double FindSum(double[] arr, bool odd)
    {
        double sum = 0.0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (odd == true && i % 2 == 0)
            {
                sum += arr[i];
            }
            else if (odd == false && i % 2 != 0)
            {
                sum += arr[i];
            }
        }

        return sum;
    }

    private static double[] FindValues(double[] arr, bool odd)
    {
        int length = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (odd == true && i % 2 == 0)
            {
                length++;
            }
            else if (odd == false && i % 2 != 0)
            {
                length++;
            }
        }

        double[] values = new double[length];
        int index = 0;

        for (int j = 0; j < arr.Length; j++)
        {
            if (odd == true && j % 2 == 0)
            {
                values[index] = arr[j];
                index++;
            }
            else if (odd == false && j % 2 != 0)
            {
                values[index] = arr[j];
                index++;
            }
        }

        return values;
    }

    private static string FindMin(double[] arr)
    {
        string result = "No";

        if (arr.Length > 0)
        {
            double min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            result = min.ToString();
        }        

        return result;
    }

    private static string FindMax(double[] arr)
    {
        string result = "No";

        if (arr.Length > 0)
        {
            double max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            result = max.ToString();
        }
        

        return result;
    }
}
