using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {

            int.TryParse(Console.ReadLine(), out int x);

            Console.WriteLine(x);
            if(x == 0)
            {
                Console.WriteLine("This is not a valid input.");
            }
            else
            {
                Console.WriteLine("You have entered no. " + x );
            }
        }
    }
}
