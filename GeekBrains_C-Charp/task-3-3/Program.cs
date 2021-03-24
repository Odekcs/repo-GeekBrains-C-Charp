using System;

namespace task_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string text = Console.ReadLine();
            string word = "";

            for (int i = text.Length - 1; i >= 0; --i)
            {
                word += text[i];
            }
            Console.WriteLine(word);
        }
    }
}
