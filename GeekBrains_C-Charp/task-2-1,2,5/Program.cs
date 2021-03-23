using System;

namespace task_2_1_2_5
{
    class Program
    {
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the maximum temperature: ");
            int max_t = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the minimum temperature: ");
            int min_t = Convert.ToInt32(Console.ReadLine());

            float medium_t = (float)(max_t + min_t) / 2;
            Console.WriteLine($"The medium temperature is {medium_t}.");

            Console.Write("Enter the number of the this month: ");
            byte num_month = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"This is {(Months)num_month}");

            if (num_month <= 3 && num_month > 0 || num_month == 12 && medium_t > 0)
            {
                Console.WriteLine("Rainy winter!");
            }
        }
    }
}
