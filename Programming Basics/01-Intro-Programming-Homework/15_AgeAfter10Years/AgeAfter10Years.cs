using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Write your birthday date (day.month.year): ");
        
        string birthdayDate = Console.ReadLine();
        string[] givenDate = birthdayDate.Split('.');

        if (givenDate.Length == 3)
        {
            DateTime date = DateTime.Now;
            DateTime birthDate = new DateTime(Convert.ToInt32(givenDate[2]), 
                Convert.ToInt32(givenDate[1]), 
                Convert.ToInt32(givenDate[0]));

            int age = 0;

            if (date.Month <= birthDate.Month && date.Day > birthDate.Day)
            {
                age = (date.Year - birthDate.Year) - 1;
            }
            else
            {
                age = date.Year - birthDate.Year;
            }

            Console.WriteLine("Now: {0}", age);
            Console.WriteLine("After 10 years: {0}", age + 10);
        }
    }
}
