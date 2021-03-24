using System;

namespace task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array =
            {
                {1, 4, 3, 4, 5},
                {6, 1, 8, 9, 0},
                {1, 2, 1, 4, 5},
                {6, 7, 8, 1, 0},
                {3, 8, 6, 1, 1}
            };

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(Array[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
