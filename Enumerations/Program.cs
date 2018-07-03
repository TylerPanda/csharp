using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WeekDay day = WeekDay.Friday;
            Console.WriteLine(day);
            Console.WriteLine((int)day);
        }
    }
    enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
