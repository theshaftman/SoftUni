using System;

namespace _03_Employee_Data
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            long age = long.Parse(Console.ReadLine());
            string employeeId = string.Format("{0:D8}", long.Parse(Console.ReadLine()));
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Name: {1}{0}Age: {2}{0}Employee ID: {3}{0}Salary: {4:F2}", 
                Environment.NewLine, 
                name, 
                age, 
                employeeId, 
                salary);
        }
    }
}
