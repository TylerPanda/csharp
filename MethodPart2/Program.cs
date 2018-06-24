using System;

namespace MethodPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b ,c ,d;
            int addResult = 0;

            a = 5;
            b = 3;
            addResult = performAddResult(a, b);
            displayMessages();

            c = 10;
            d = 15;
            addResult = performAddResult(c, d);
            displayMessages();

        }
        
        static int performAddResult(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            return addResult;
        }

        static void displayMessages()
        {
            Console.WriteLine("Process is done.");
            Console.WriteLine("This process is run by ahmad.");
            Console.WriteLine("Finished time : " + DateTime.Now.ToShortTimeString());
        }
    }
}
