using System;

namespace task_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter any number: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Even number!");
                }
                else
                {
                    Console.WriteLine("Odd number!");
                }
            }
        }
    }
}
