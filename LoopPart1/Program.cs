using System;

namespace LoopPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Increment ==========");
            for (int i = 0 ; i <= 10 ; i++)
            {
                Console.WriteLine("The value of variable is " + i);
            }
            Console.WriteLine("========== Decrease ==========");
            for (int i = 10 ; i>=1 ; i--)
            {
                Console.WriteLine("The value of variable is " + i);
            }
            Console.WriteLine("========== Break ==========");
            for(int i = 10 ; i >= 1 ; i--)
            {
                if(i == 2)
                {
                    break;
                }
                Console.WriteLine("The value of variable is " + i);
            }
        }
    }
}
