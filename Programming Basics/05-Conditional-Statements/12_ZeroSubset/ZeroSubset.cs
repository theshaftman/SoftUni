using System;

class ZeroSubset
{
    static void Main()
    {
        Subset();
    }

    private static void Subset()
    {
        string str = Console.ReadLine();
        string[] arrStr = str.Split(' ');
        int[] arr = IntArr(arrStr);

        if (arr.Length == 5)
        {
            EqualZero(arr);
        }
        else
        {
            Console.WriteLine("Write 5 integer numbers!");
        }
    }

    private static int[] IntArr(string[] arrStr)
    {
        int[] arr = new int[arrStr.Length];
        int numbers;

        for (int i = 0; i < arrStr.Length; i++)
        {
            if (int.TryParse(arrStr[i], out numbers))
            {
                arr[i] = int.Parse(arrStr[i]);
            }
            else
            {
                return new int[]{-1};
            }
        }

        return arr;
    }

    private static void EqualZero(int[] arr)
    {
        string result = string.Empty;
        int a = arr[0];
        int b = arr[1];
        int c = arr[2];
        int d = arr[3];
        int e = arr[4];

        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }
        else
        {
            Console.WriteLine("no zero subset");
        }
    }
}
