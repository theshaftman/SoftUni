using System;

class WorkHours
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine()); //required hours
        int days = int.Parse(Console.ReadLine()); //days work
        int prod = int.Parse(Console.ReadLine()); //productivity

        if (hours >= 0 && hours <= int.MaxValue)
        {
            if (days >= 0 && days <= 89478485)
            {
                if (prod >= 0 && prod <= 100)
                {
                    double workingDays = days - ((days * 10.0) / 100.0);
                    double hoursWorking = ((workingDays * 12.0) * prod) / 100.0;
                    string value = hoursWorking.ToString();
                    string result = string.Empty;
                    string resultStr = string.Empty;

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] == '.')
                        {
                            break;
                        }

                        result += value[i].ToString();
                    }

                    int res = int.Parse(result);
                    int difference = res - hours;

                    if (res >= hours)
                    {
                        resultStr = "Yes";
                    }
                    else
                    {
                        resultStr = "No";
                    }

                    Console.WriteLine(resultStr);
                    Console.WriteLine(difference);
                }
            }
        }
    }
}
