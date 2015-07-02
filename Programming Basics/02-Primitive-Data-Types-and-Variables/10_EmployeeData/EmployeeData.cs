using System;

class EmployeeData
{
    static void Main()
    {
        Random randomGenerator = new Random();

        string firstName = "Amanda";
        string lastName = "Jonson";
        byte age = 27;
        char gender = 'f';
        string personalID = string.Empty;
        string uniqueEN = Convert.ToString(randomGenerator.Next(27563571, 99999999));

        for (int i = 0; i < 10; i++)
        {
            personalID += Convert.ToString(randomGenerator.Next(10));
        }

        if (age <= 100)
        {
            if (gender == 'm' || gender == 'f')
            {
                Console.WriteLine("First name: {0}", firstName);
                Console.WriteLine("Last name: {0}", lastName);
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Gender: {0}", gender);
                Console.WriteLine("Personal ID: {0}", personalID);
                Console.WriteLine("Unique Employee number: {0}", uniqueEN);
            }
            else
            {
                Console.WriteLine("Type 'm' or 'f' as a gender.");
            }
        }
        else
        {
            Console.WriteLine("Type age less than 100 years");
        }
    }
}
