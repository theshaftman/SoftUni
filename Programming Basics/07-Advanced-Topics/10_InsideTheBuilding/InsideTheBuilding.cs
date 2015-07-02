using System;

class InsideTheBuilding
{
    static void Main()
    {
        uint h = uint.Parse(Console.ReadLine());
        Position[] position = new Position[5];
        
        for (int i = 0; i < position.Length; i++)
        {
            position[i] = new Position(int.Parse(Console.ReadLine()), 
                int.Parse(Console.ReadLine()));
        }

        for (int j = 0; j < position.Length; j++)
        {
            Console.WriteLine(CheckPosition(position[j], h));
        }
    }

    private static string CheckPosition(Position pos, uint h)
    {
        string result = "outside";

        if (pos.X >= 0 && pos.X <= h * 3)
        {
            if (pos.Y >= 0 && pos.Y <= h)
            {
                result = "inside";
            }
            else if (pos.X >= h && pos.X <= h * 2)
            {
                if (pos.Y >= h && pos.Y <= h * 4)
                {
                    result = "inside";
                }
            }
        }

        return result;
    }
}

public class Position
{

    public int X { get; set; }
    public int Y { get; set; }
    public Position() { }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}
