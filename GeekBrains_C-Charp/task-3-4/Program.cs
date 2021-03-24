using System;

namespace task_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] War =
            {
                {'O','X','X','X','O','O','O','O','O','O'},
                {'O','O','O','O','O','O','O','X','X','X'},
                {'X','O','O','O','O','X','O','O','O','O'},
                {'O','O','X','O','O','O','O','O','O','O'},
                {'O','O','X','O','O','O','O','O','X','X'},
                {'O','O','X','O','O','X','O','O','O','O'},
                {'X','O','X','O','O','O','O','O','O','O'},
                {'X','O','O','O','O','O','O','O','O','O'},
                {'O','O','O','O','O','O','O','X','O','O'},
                {'X','X','O','O','O','O','O','O','O','O'}
            };

            for (int i = 0; i < War.GetLength(0); i++)
            {
                for (int j = 0; j < War.GetLength(1); j++)
                {
                    Console.Write(War[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
