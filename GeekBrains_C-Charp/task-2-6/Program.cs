using System;

namespace task_2_6
{
    class Program
    {
        [Flags]
        enum Week
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000
        }

        static void Main(string[] args)
        {
            Week office_1 = (Week)0b_1010111;
            Week office_2 = (Week)0b_1111001;

            Console.WriteLine($"Office 1 works: {office_1}.");
            Console.WriteLine($"Office 2 works: {office_2}.");
        }
    }
}
