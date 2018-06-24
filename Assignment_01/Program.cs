using System;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's ypur name?");
            var name = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0}, My name is C#, How old are you?", name);
            int.TryParse(Console.ReadLine(), out int age);
            if (age == 0)
            {
                Console.WriteLine("That is not a correct input");
            }
            else
            {
                Console.WriteLine("{0} good, As for me I was born on 2002. Which makes me {1} years old.", age, DateTime.Now.Year - 2002);
            }

            Console.WriteLine("Enter the day ....");
            var day = Console.ReadLine();

            Console.WriteLine("Enter the month ...");
            var month = Console.ReadLine();

            Console.WriteLine("Enter the year ...");
            var year = Console.ReadLine(); 

            DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            Console.WriteLine("\nThe day should be " + date.DayOfWeek);

            var now = DateTime.Now.DayOfWeek.ToString();

            switch(now)
            {
                case "Saturday":
                    Console.WriteLine("Yellow.");
                    break;
                case "Sunday":
                    Console.WriteLine("Green.");
                    break;
                case "Monday":
                    Console.WriteLine("Blue.");
                    break;
                case "Tuesday":
                    Console.WriteLine("Grey.");
                    break;
                case "Wednesday":
                    Console.WriteLine("Red.");
                    break;
                case "Thursday":
                    Console.WriteLine("Orange.");
                    break;
                case "Friday":
                    Console.WriteLine("White.");
                    break;
            }
        }
    }
}
