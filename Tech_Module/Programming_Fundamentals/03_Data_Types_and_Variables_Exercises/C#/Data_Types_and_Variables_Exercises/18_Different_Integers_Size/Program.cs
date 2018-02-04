using System;

namespace _18_Different_Integers_Size
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();
            try
            {
                long number = long.Parse(line);
                string result = string.Empty;
                if (number >= -128 && number <= 127)
                {
                    result += string.Format("* sbyte{0}", Environment.NewLine);
                }
                if (number >= 0 && number <= 255)
                {
                    result += string.Format("* byte{0}", Environment.NewLine);
                }
                if (number >= -32768 && number <= 32767)
                {
                    result += string.Format("* short{0}", Environment.NewLine);
                }
                if (number >= 0 && number <= 65535)
                {
                    result += string.Format("* ushort{0}", Environment.NewLine);
                }
                if (number >= -2147483648 && number <= 2147483647)
                {
                    result += string.Format("* int{0}", Environment.NewLine);
                }
                if (number >= 0 && number <= 4294967295L)
                {
                    result += string.Format("* uint{0}", Environment.NewLine);
                }
                if (number >= long.MinValue && number <= long.MaxValue)
                {
                    result += string.Format("* long{0}", Environment.NewLine);
                }
                Console.Write("{0} can fit in:{2}{1}", line, result, Environment.NewLine);
            }
            catch (Exception e)
            {
                Console.WriteLine(line + " can't fit in any type");
            }
        }
    }
}
