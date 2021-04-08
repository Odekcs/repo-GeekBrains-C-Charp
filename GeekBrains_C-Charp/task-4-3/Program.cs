using System;

namespace task_4_3
{
    class Program
    {
        enum SeasonEnum
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Error
        }
        static void Main(string[] args)
        {
            SeasonEnum season = SeasonEnum.Error;
            string seasonRus = String.Empty;

            do
            {
                Console.Clear();
                if (season == SeasonEnum.Error) Console.WriteLine(seasonRus);
                Console.Write("Enter the number of the current month: ");
                int monthNumber = Convert.ToInt32(Console.ReadLine());

                (season, seasonRus) = GetSeason(monthNumber);

            } while (season == SeasonEnum.Error);

            Console.WriteLine($"{seasonRus} is now."); 
        }
        static (SeasonEnum, string) GetSeason(int month)
        {
            SeasonEnum season = SeasonEnum.Error;
            string msg = "Error, please enter a number between 1 and 12.";
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = SeasonEnum.Winter;
                    msg = "Winter";
                    return (season, msg);
                case 3:
                case 4:
                case 5:
                    season = SeasonEnum.Spring;
                    msg = "Spring";
                    return (season, msg);
                case 6:
                case 7:
                case 8:
                    season = SeasonEnum.Summer;
                    msg = "Summer";
                    return (season, msg);
                case 9:
                case 10:
                case 11:
                    season = SeasonEnum.Autumn;
                    msg = "Autumn";
                    return (season, msg);
            }
            return (season, msg);
        }
    }
}
