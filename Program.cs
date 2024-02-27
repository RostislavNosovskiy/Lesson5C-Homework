namespace Lesson5;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        int[,] labirynth = new int[,]
        {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {2, 0, 0, 0, 1, 0, 2 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 },
            {1, 1, 1, 2, 1, 2, 1 }

        };
        Console.WriteLine(HasExit(1, 1, labirynth));
        
    }
    static int HasExit(int StartI, int StartJ, int[,] labirinth)
    {
        Queue<(int, int)> cords = new();
        int counter = 0;

        if (labirinth[StartI, StartJ] != 1)
        {
            cords.Enqueue((StartI, StartJ));

        }
        while (cords.Count > 0)
        {
            (int i, int j) = cords.Dequeue();
            if (labirinth[i, j] == 2)
            {
                counter++;
                labirinth[i, j] = 1;
            }
            else
            { 
                labirinth[i, j] = 1;
                if (i - 1 >= 0 && labirinth[i - 1, j] != 1) cords.Enqueue((i - 1, j));
                if (i + 1 < labirinth.GetLength(0) && labirinth[i + 1, j] != 1) cords.Enqueue((i + 1, j));
                if (j - 1 >= 0 && labirinth[i, j - 1] != 1) cords.Enqueue((i, j - 1));
                if (j + 1 < labirinth.GetLength(1) && labirinth[i, j + 1] != 1) cords.Enqueue((i, j + 1));
            }
        }
        return counter;
    }



}
