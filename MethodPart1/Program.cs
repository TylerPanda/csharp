using System;

namespace MethodPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;

            a = 5;
            b = 3;
            addResult = a + b;
            Console.WriteLine($"{a} + {b} = {addResult}");
            displayMessages();

            c = 10;
            d = 15;
            addResult = c + d;
            Console.WriteLine($"{c} + {d} = {addResult}");
            displayMessages();
        }

        static void displayMessages()
        {
            Console.WriteLine("Process is done.");
            Console.WriteLine("This process is run by ahmad.");
            Console.WriteLine("Finished on time : " + DateTime.Now.ToShortTimeString());
        }
    }
}
