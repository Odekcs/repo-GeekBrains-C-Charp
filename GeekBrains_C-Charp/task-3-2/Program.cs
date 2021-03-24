using System;

namespace task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] book =
            {
                {"Dmitry", "8 999 999 99 99"},
                {"Dmitry", "8 999 999 99 99"},
                {"Dmitry", "8 999 999 99 99"},
                {"Dmitry", "8 999 999 99 99"},
                {"Dmitry", "8 999 999 99 99"}
            };

            for (int i = 0; i < book.GetLength(0); i++)
            {
                for (int j = 0; j < book.GetLength(1); j++)
                {
                    Console.Write("{0,-15}", book[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
