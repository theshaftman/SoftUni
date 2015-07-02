using System;

class SumOfElements
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] arrStr = str.Split(' ');
        string result = string.Empty;

        if (arrStr.Length >= 2 && arrStr.Length <= 1000)
        {
            int[] arr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }

            Array.Sort(arr);

            int sum = 0;

            for (int j = 0; j < arr.Length - 1; j++)
            {
                sum += arr[j];
            }

            if (sum == arr[arr.Length - 1])
            {
                result = "Yes, sum = " + sum.ToString();
            }
            else if (sum > arr[arr.Length - 1])
            {
                result = "No, diff = " + (sum - arr[arr.Length - 1]).ToString();
            }
            else
            {
                result = "No, diff = " + (arr[arr.Length - 1] - sum).ToString();
            }

            Console.WriteLine(result);
        }
    }
}
