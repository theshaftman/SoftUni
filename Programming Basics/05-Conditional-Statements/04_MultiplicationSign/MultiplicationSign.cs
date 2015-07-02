using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine(Sign());
    }

    private static char Sign()
    {
        string[] strArr = new string[3];
        int minus = 0;

        for (int i = 0; i < strArr.Length; i++)
        {
            strArr[i] = Console.ReadLine();
        }

        minus = CheckMinus(strArr);

        if (CheckZero(strArr))
        {
            if (minus % 2 == 0)
            {
                return '+';
            }

            return '-';
        }

        return '0';
    }

    private static bool CheckZero(string[] arr)
    {
        double numbers;

        for (int i = 0; i < arr.Length; i++)
        {
            if (double.TryParse(arr[i], out numbers) && double.Parse(arr[i]) == 0)
            {
                return false;
            }
        }

        return true;
    }

    private static int CheckMinus(string[] arr)
    {
        int result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i][0] == '-')
            {
                result++;
            }
        }

        return result;
    }
}
