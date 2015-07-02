class PrintSequence
{
    static void Main()
    {
        string result = string.Empty;
        int i = 0;

        while (i < 10)
        {
            if (i != 0)
            {
                result += ",";
            }
            if (i % 2 != 0)
            {
                result += "-";
            }

            result += i + 2;
            i++;
        }

        System.Console.WriteLine(result);
    }
}
