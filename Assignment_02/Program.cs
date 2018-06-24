using System;

namespace Assignment_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= Upside down triangle =========");
            for (int i = 20 ; i >= 0 ; i--)
            {
                for (int j = 0 ; j <= i ; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.WriteLine("========= Months and Days =========");

            string formattedDate = "";

            Console.WriteLine("Enter the day:");
            var day = Console.ReadLine();

            Console.WriteLine("Enter the month:");
            var month = Console.ReadLine();

            Console.WriteLine("Enter the year:");
            var year = Console.ReadLine();

            DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            formattedDate = string.Format($"{date: dd-MM-yyyy}");
            Console.WriteLine(formattedDate + date.DayOfWeek);

            Console.WriteLine("========= Dice Roller =========");
            string input = "";
            Random rand = new Random();
            int x = 0;
            do
            {
                Console.WriteLine("Roll dice?(yes or no):");
                input = Console.ReadLine();
                if( input.ToLower() == "yes")
                {
                    x = rand.Next(1, 7);
                    Console.WriteLine("New dice no is :" + x);
                }
            }while( input.ToLower() != "no");

        }
    }
}
