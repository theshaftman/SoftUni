using System;
using System.Numerics;

namespace _19_Thea_The_Photographer
{
    public class Program
    {
        public static void Main(String[] args)
        {
            long totalCount = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            double filterFactorPercentage = double.Parse(Console.ReadLine());
            long uploadingTime = long.Parse(Console.ReadLine());
            BigInteger firstTime = new BigInteger(totalCount) * new BigInteger(filterTime);

            BigInteger secondTime = CheckTime((totalCount * filterFactorPercentage / 100.0).ToString()) * uploadingTime;
            BigInteger resultTime = firstTime + secondTime;

            Console.WriteLine(CalculateTime(long.Parse(string.Format("{0}", resultTime))));
        }

        private static BigInteger CheckTime(string value)
        {
            int index = value.LastIndexOf(".");
            if (index.Equals(-1))
            {
                return BigInteger.Parse(value);
            }
            else
            {
                if (double.Parse(value).Equals(double.Parse(value.Substring(0, index))))
                {
                    return BigInteger.Parse(value);
                }
                else
                {
                    return BigInteger.Parse(value.Substring(0, index)) + 1;
                }
            }
        }

        public static string CalculateTime(BigInteger seconds)
        {
            BigInteger sec = seconds % 60;
            BigInteger minutes = seconds % 3600 / 60;
            BigInteger hours = seconds % 86400 / 3600;
            BigInteger days = seconds / 86400;

            return string.Format("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, minutes, sec);
        }
    }
}
