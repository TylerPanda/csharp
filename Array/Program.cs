using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] {1, 10, 100, 1000, 10000};
            // string[] weekDays = new string[7] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
            string[] weekDays = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

            for (int i = 0 ; i < numbers.Length ; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (var item in weekDays)
            {
                Console.WriteLine(item);
            }
        }
    }
}
