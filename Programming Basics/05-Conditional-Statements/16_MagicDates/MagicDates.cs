using System;

class MagicDates
{
    static void Main()
    {
        Dates();
    }

    private static void Dates()
    {
        string givenDateA = CheckDate();
        string givenDateB = CheckDate();
        int magicWeight = int.Parse(Console.ReadLine());

        if (CheckYear(givenDateA) && CheckYear(givenDateB) && int.Parse(givenDateB) >= int.Parse(givenDateA))
        {
            DateTime startYear = DateTime.ParseExact(givenDateA, "yyyy", null);
            DateTime endYear = DateTime.ParseExact(givenDateB, "yyyy", null);
            endYear = endYear.AddDays(1);
            bool isThereResult = false;

            while (startYear.Year <= endYear.Year)
            {
                string startDate = startYear.ToString("ddMMyyyy");
                int weight = CountWeight(startDate);

                if (weight == magicWeight)
                {
                    Console.WriteLine(startYear.ToString("dd-MM-yyyy"));

                    isThereResult = true;
                }

                startYear = startYear.AddDays(1);
            }

            if (!isThereResult)
            {
                Console.WriteLine("No");
            }
        }
    }

    private static string CheckDate()
    {
        string givenDate = Console.ReadLine();

        if (givenDate.Length < 4)
        {
            givenDate = givenDate.Insert(0, new string('0', 4 - givenDate.Length));
        }
        
        return givenDate;
    }

    private static bool CheckYear(string yearStr)
    {
        int year = int.Parse(yearStr);

        if (year >= 1900 && year <= 2100)
        {
            return true;
        }

        return false;
    }

    private static int CountWeight(string date)
    {
        int count = 0;

        for (int i = 0; i < date.Length; i++)
        {
            for (int j = i + 1; j < date.Length; j++)
            {
                count += int.Parse(date[i].ToString()) * int.Parse(date[j].ToString());
            }
        }

        return count;
    }
}
