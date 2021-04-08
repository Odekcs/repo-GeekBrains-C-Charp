using System;

namespace task_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Dima", "Gorbachyov", "Valerevich"));
            Console.WriteLine(GetFullName("Vika", "Oreshkina", "Koka"));
            Console.WriteLine(GetFullName("Lisya", "Lada", "Kila"));
            Console.WriteLine(GetFullName("Tesla", "Ori", "Gromche"));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"Hello, {firstName} {lastName} {patronymic}.";
        }
    }
}
