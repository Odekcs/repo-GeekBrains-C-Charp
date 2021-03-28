using System;

namespace task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int totalsumm;

                Console.Write("Enter numbers separated by a space: ");
                string strNumbers = Console.ReadLine();

                totalsumm = SummNumbersStr(strNumbers);
                Console.WriteLine(totalsumm);
            }
        }
        static int SummNumbersStr(string str)
        {
            int summ = 0;
            string[] strNumbers = str.Split(new char[] { ' ' });

            for (int i = 0; i < strNumbers.Length; i++)
            {
                if (char.IsNumber(str[i]))
                {

                    summ += Convert.ToInt32(strNumbers[i]);
                }
            }
            return summ;
        }
    }
}
