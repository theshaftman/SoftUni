﻿using System;

namespace _04_Month_Printer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string result = string.Empty;
            switch (month)
            {
                case 1:
                    result = "January";
                    break;
                case 2:
                    result = "February";
                    break;
                case 3:
                    result = "March";
                    break;
                case 4:
                    result = "April";
                    break;
                case 5:
                    result = "May";
                    break;
                case 6:
                    result = "Juny";
                    break;
                case 7:
                    result = "July";
                    break;
                case 8:
                    result = "August";
                    break;
                case 9:
                    result = "September";
                    break;
                case 10:
                    result = "October";
                    break;
                case 11:
                    result = "November";
                    break;
                case 12:
                    result = "December";
                    break;
                default:
                    result = "Error!";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
