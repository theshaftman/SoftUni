using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 != 0 && n >= 5 && n <= 49)
        {
            int outside = (n - 1) / 2;
            int roof = -1;
            string result = string.Empty;
            char wall = '*';
            char outWall = '.';

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    result = new string(outWall, outside) + wall.ToString() + 
                        new string(outWall, outside);
                }
                else if (i < (n - 1) / 2)
                {
                    result = new string(outWall, outside) + wall.ToString() + 
                        new string(outWall, roof) + wall.ToString() + 
                        new string(outWall, outside);
                }
                else if (i == (n - 1) / 2)
                {
                    result = new string(wall, n);
                }                
                else if (i == n - 1)
                {
                    result = outWall.ToString() + new string(wall, n - 2) + 
                        outWall.ToString();
                }
                else if (i > (n - 1) / 2)
                {
                    result = outWall.ToString() + wall.ToString() + new string(outWall, n - 4) +
                        wall.ToString() + outWall.ToString();
                }

                Console.WriteLine(result);

                roof += 2;
                outside--;
            }
        }
    }
}
