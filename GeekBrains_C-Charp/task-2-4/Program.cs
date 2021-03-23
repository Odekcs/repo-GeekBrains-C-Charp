using System;

namespace task_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2018, 2, 1, 11, 32, 0);
            string t_shirt = "T-Shirt";
            string watches = "Watches";
            string pants = "Pants";
            string socks = "Socks";
            decimal a = 25.50M;
            decimal b = 299.00M;
            decimal c = 32.99M;
            decimal d = 6.50M;
            decimal total = 363.99M;
            decimal cash = 400.00M;
            decimal change = 36.01M;
            int approval = 192107;

            Console.WriteLine("************************************");
            Console.WriteLine("              RECEIPT            ");
            Console.WriteLine("************************************");
            Console.WriteLine($" Terminal#1     {date}");
            Console.WriteLine("====================================");
            Console.WriteLine($"\n 1 x {t_shirt}              ${a} ");
            Console.WriteLine($"\n 1 x {pants}                ${c} ");
            Console.WriteLine($"\n 1 x {watches}              ${b} ");
            Console.WriteLine($"\n 1 x {socks}                ${d} ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($" Total Amount             ${total} ");
            Console.WriteLine($" Cash                     ${cash} ");
            Console.WriteLine($" Change                   ${total} ");
            Console.WriteLine("====================================\n");
            Console.WriteLine(" Bank Card      **** **** **** 7211 ");
            Console.WriteLine($" Approval#                 {approval} ");
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("\n*************THANK YOU!*************");
        }
    }
}
