using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine(Number());
    }

    private static string Number()
    {
        string numberStr = Console.ReadLine();
        int numbers;

        if (int.TryParse(numberStr, out numbers))
        {
            int num = int.Parse(numberStr);
            string result = string.Empty;

            if (num >= 0 && num <= 999)
            {
                if (numberStr.Length == 1)
                {
                    result = DigitFirst(numberStr);
                }
                else if (numberStr.Length == 2)
                {
                    result = DigitSecond(numberStr);
                }
                else if (numberStr.Length == 3)
                {
                    result = DigitThird(numberStr);
                }

                result = result[0].ToString().ToUpper() + result.Remove(0, 1);
                return result;
            }
        }

        return "write a number in the range [0 - 999]";
    }

    private static string DigitFirst(string n)
    {
        switch (n)
        {
            case "1": return "one";
            case "2": return "two";
            case "3": return "three";
            case "4": return "four";
            case "5": return "five";
            case "6": return "six";
            case "7": return "seven";
            case "8": return "eight";
            case "9": return "nine";
        }

        return "zero";
    }

    private static string DigitSecond(string n)
    {
        string result = string.Empty;

        switch (n[0].ToString())
        {
            case "0": return DigitFirst(n[1].ToString());
            case "1": return TenToTwenty(n);
            case "2": result = "twenty"; break;
            case "3": result = "thirty"; break;
            case "4": result = "fourty"; break;
            case "5": result = "fifty"; break;
            case "6": result = "sixty"; break;
            case "7": result = "seventy"; break;
            case "8": result = "eighty"; break;
            case "9": result = "ninety"; break;
        }

        return result + End(n[1].ToString());
    }

    private static string TenToTwenty(string n)
    {
        switch (n)
        {
            case "11": return "eleven";
            case "12": return "twenty";
            case "13": return "thirteen";
            case "14": return "fourteen";
            case "15": return "fifteen";
            case "16": return "sixteen";
            case "17": return "seventeen";
            case "18": return "eighteen";
            case "19": return "nineteen";
        }
        
        return "ten";
    }

    private static string End(string n)
    {
        switch (n)
        {
            case "1": return " one";
            case "2": return " two";
            case "3": return " three";
            case "4": return " four";
            case "5": return " five";
            case "6": return " six";
            case "7": return " seven";
            case "8": return " eight";
            case "9": return " nine";
        }

        return "";
    }

    private static string DigitThird(string n)
    {
        string result = string.Empty;

        switch (n[0].ToString())
        {
            case "0": return DigitSecond(n[1].ToString() + n[2].ToString());
            case "1": result = "one hundred"; break;
            case "2": result = "two hudred"; break;
            case "3": result = "three hundred"; break;
            case "4": result = "four hundred"; break;
            case "5": result = "five hundred"; break;
            case "6": result = "six hundred"; break;
            case "7": result = "seven hundred"; break;
            case "8": result = "eight hundred"; break;
            case "9": result = "nine hundred"; break;
        }

        if (n[1].ToString() + n[2].ToString() == "00")
        {
            return result;
        }
            
        result += " and ";

        return result + DigitSecond(n[1].ToString() + n[2].ToString());
    }
}
