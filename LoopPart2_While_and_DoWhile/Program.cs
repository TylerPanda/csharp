using System;

namespace LoopPart2_While_and_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while Loop");
            int x = 8;

            while(x >= 1)
            {
                if(x == 3)
                {
                    break;    
                }
                Console.WriteLine("Game of thrones season 0" + x);
                x--;
            }
            Console.WriteLine("----------");
            Console.WriteLine("Do while Loop");

            int i = 0;
            do
            {
                Console.WriteLine("This is the line no." + i);
                i++;
            } while (i <= 10);
        }
    }
}
