using System;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;

            // Console.WriteLine("Input the Number one: ");
            // x = int.Parse(Console.ReadLine());
            // Console.WriteLine("Input the Number two: ");
            // y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("Number one is greater than Number two.");
            }
            else if (x < y)
            {
                Console.WriteLine("Number one is less than number two.");
            }
            else if (x == y)
            {
                Console.WriteLine("They matches!");
            }
            
            Console.WriteLine("Are you enjoying C#? (Yes or No)");
            string input = Console.ReadLine();

            switch(input)
            {
                case "Yes": Console.WriteLine("This is very good");
                break;
                case "No": Console.WriteLine("So sorrythat you are not enjoying");
                break;
                default : Console.WriteLine("This is not a correct answer");
                break;
            }
        }
    }
}
